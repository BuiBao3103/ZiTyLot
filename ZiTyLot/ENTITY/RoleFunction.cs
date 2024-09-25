using System;

namespace ZiTyLot.ENTITY
{
    public class RoleFunction
    {
        private int id;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private Role role;
        private Function function;

        public int Id { get => id; set => id = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Role Role { get => role; set => role = value; }
        public Function Function { get => function; set => function = value; }

    }
}
