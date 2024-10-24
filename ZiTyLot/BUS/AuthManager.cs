using System;
using System.Collections.Generic;
using System.Diagnostics;
using ZiTyLot.ENTITY;
namespace ZiTyLot.BUS
{
    public class AuthManager
    {
        private static bool IsAuthenticated { get; set; }
        private static Account CurrentAccount { get; set; }
        
        private AccountBUS accountBUS = new AccountBUS();
        private RoleBUS roleBUS = new RoleBUS();

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password are required");
            }
            username = username.Trim();
            password = password.Trim();
            List<FilterCondition> filters = new List<FilterCondition>() {
                new FilterCondition("username",CompOp.Equals,username),
            };
            List<Account> accounts = accountBUS.GetAll(filters);
            if (accounts.Count == 0)
            {
                throw new Exception("Username or password is incorrect");
            }
            Account account = accounts[0];
            if (account.Password != password)
            {
                throw new Exception("Username or password is incorrect");
            }

            IsAuthenticated = true;
            CurrentAccount = account;
        }
        public static void Logout()
        {
            IsAuthenticated = false;
            CurrentAccount = null;
        }
    }
}
