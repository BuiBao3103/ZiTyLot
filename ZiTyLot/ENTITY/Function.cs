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

        //relationships
        private ICollection<RoleFunction> role_functions = new List<RoleFunction>();

        //relationship many to many
        private ICollection<Role> roles = new List<Role>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ICollection<RoleFunction> Role_functions { get => role_functions; set => role_functions = value; }
        public string Icon { get => icon; set => icon = value; }
        public string Active_icon { get => active_icon; set => active_icon = value; }
        public ICollection<Role> Roles { get => roles; set => roles = value; }

        // Override ToString để fix lỗi hiển thị trong listBox của RoleCreateForm
        public override string ToString() { return Name; }
    }
}
