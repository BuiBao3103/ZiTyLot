using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Role
    {
        private int id;
        private string name;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private ICollection<RoleFunction> role_functions = new List<RoleFunction>();
        private ICollection<Account> accounts = new List<Account>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        //public ICollection<RoleFunction> RoleFunctions { get => role_functions; set => role_functions = value; }
        public ICollection<Account> Accounts { get => accounts; set => accounts = value; }

    }
}
