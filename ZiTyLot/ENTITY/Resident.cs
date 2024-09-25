using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Resident
    {
        private int id;
        private string full_name;
        private string phone;
        private string email;
        private string apartment_id;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private ICollection<Bill> bills = new List<Bill>();

        public int Id { get => id; set => id = value; }
        public string FullName { get => full_name; set => full_name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string ApartmentId { get => apartment_id; set => apartment_id = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public ICollection<Bill> Bills { get => bills; set => bills = value; }
    }
}
