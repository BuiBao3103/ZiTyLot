using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.ENTITY
{
    public class Slot
    {
        //attributes
        private string id;
        private SlotStatus status;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private string parking_lot_id;

        //relationships
        private ParkingLot parking_lot = null;
        private ICollection<Issue> issues = new List<Issue>();

        public string Id { get => id; set => id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public string Parking_lot_id { get => parking_lot_id; set => parking_lot_id = value; }
        public ParkingLot Parking_lot { get => parking_lot; set => parking_lot = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
        public SlotStatus Status { get => status; set => status = value; }
    }
}
