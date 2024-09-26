using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Function
    {
        //attributes
        private int id;
        private string name;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private ICollection<RoleFunction> role_functions = new List<RoleFunction>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ICollection<RoleFunction> Role_functions { get => role_functions; set => role_functions = value; }
    }
}
