using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class ParkingLot
    {
        private string id;
        private int total_slot;
        private ParkingLotType parking_lot_type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private string parking_lot_id;
        private ICollection<Slot> slots = new List<Slot>();
        private ICollection<Issue> issues = new List<Issue>();

        public string Id { get => id; set => id = value; }
        public int Total_slot { get => total_slot; set => total_slot = value; }
        public ParkingLotType Parking_lot_type { get => parking_lot_type; set => parking_lot_type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public string Parking_lot_id { get => parking_lot_id; set => parking_lot_id = value; }
        public ICollection<Slot> Slots { get => slots; set => slots = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
    }
}
