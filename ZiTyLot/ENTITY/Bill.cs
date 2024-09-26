using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Bill
    {
        //attributes
        private int id;
        private double total_fee;
        private int issue_quantity;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? account_id;
        private int? resident_id;

        //relationships
        private Account account = null;
        private Resident resident = null;
        private ICollection<Issue> issues = new List<Issue>();

        public int Id { get => id; set => id = value; }
        public double Total_fee { get => total_fee; set => total_fee = value; }
        public int Issue_quantity { get => issue_quantity; set => issue_quantity = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Account_id { get => account_id; set => account_id = value; }
        public int? Resident_id { get => resident_id; set => resident_id = value; }
        public Account Account { get => account; set => account = value; }
        public Resident Resident { get => resident; set => resident = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
    }
}
