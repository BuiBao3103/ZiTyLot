using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Bill
    {
        private int id;
        private double total_price;
        private int issue_quantity;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private Account account;
        private Resident resident;
        private ICollection<Issue> issues = new List<Issue>();

        public int Id { get => id; set => id = value; }
        public double TotalPrice { get => total_price; set => total_price = value; }
        public int IssueQuantity { get => issue_quantity; set => issue_quantity = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Account Account { get => account; set => account = value; }
        public Resident Resident { get => resident; set => resident = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }

    }
}
