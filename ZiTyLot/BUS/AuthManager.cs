using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;
namespace ZiTyLot.BUS
{
    public class AuthManager
    {
        public static bool IsAuthenticated { get; set; }
        public static Account CurrentAccount { get; set; }
        public static Role Role { get; set; }
        public static List<Function> Functions { get; set; }
        

        private readonly AccountBUS _accountBUS = new AccountBUS();
        private readonly RoleBUS _roleBUS = new RoleBUS();

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username and password are required");
            }
            username = username.Trim();
            password = password.Trim();
            List<FilterCondition> filters = new List<FilterCondition>() {
                new FilterCondition("username", CompOp.Equals, username),
            };
            Account account = _accountBUS.GetAll(filters).FirstOrDefault();
            if (account == null || account.Password != password)
            {
                throw new Exception("Username or password is incorrect");
            }

            IsAuthenticated = true;
            CurrentAccount = account;
            Role = _accountBUS.PopulateRole(CurrentAccount).Role;
            Functions = _roleBUS.PopulateFunctions(Role).Functions;
        }
        public static void Logout()
        {
            IsAuthenticated = false;
            CurrentAccount = null;
            Role = null;
            Functions = null;
        }
    }
}
