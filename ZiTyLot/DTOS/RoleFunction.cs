using System;

namespace ZiTyLot.DTOS
{
    public class RoleFunction
    {
        //attributes
        private int? role_id;
        private int? function_id;

        //relationships
        private Role role = null;
        private Function function = null;

        public int? Role_id { get => role_id; set => role_id = value; }
        public int? Function_id { get => function_id; set => function_id = value; }
        public Role Role { get => role; set => role = value; }
        public Function Function { get => function; set => function = value; }
    }
}
