using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.DTOS
{
    public class Account
    {
        //attributes
        private int id;
        private string username;
        private string password;
        private string full_name;
        private AccountGender gender;
        private string national_id;
        private string phone;
        private string email;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? role_id;

        //relationships
        private Role role = null;
        private ICollection<Bill> bills = new List<Bill>();

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Role_id { get => role_id; set => role_id = value; }
        public Role Role { get => role; set => role = value; }
        public ICollection<Bill> Bills { get => bills; set => bills = value; }
        public AccountGender Gender { get => gender; set => gender = value; }
        public string National_id { get => national_id; set => national_id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
