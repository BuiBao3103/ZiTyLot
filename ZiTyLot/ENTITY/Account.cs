using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Account
    {
        //attributes
        private int id;
        private string username;
        private string password;
        private string full_name;
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
    }
}
