using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Slot
    {
        private string id;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private ParkingLot parking_lot;
        private ICollection<Issue> issues = new List<Issue>();

        public string Id { get => id; set => id = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime? UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime? DeletedAt { get => deleted_at; set => deleted_at = value; }
        public ParkingLot ParkingLot { get => parking_lot; set => parking_lot = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
    }
}
