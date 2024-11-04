using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Function
    {
        //attributes
        private int id;
        private string name;
        private string icon;
        private string active_icon;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private ICollection<RoleFunction> role_functions = new List<RoleFunction>();

        //relationship many to many
        private ICollection<Role> roles = new List<Role>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ICollection<RoleFunction> Role_functions { get => role_functions; set => role_functions = value; }
        public string Icon { get => icon; set => icon = value; }
        public string Active_icon { get => active_icon; set => active_icon = value; }
        public ICollection<Role> Roles { get => roles; set => roles = value; }

        // Override ToString để fix lỗi hiển thị trong listBox của RoleCreateForm
        public override string ToString() { return Name; }
    }
}
