using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.ENTITY
{
    public class ParkingLot
    {
        //attributes
        private string id;
        private int total_slot;
        private ParkingLotType type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private ICollection<Slot> slots = new List<Slot>();
        private ICollection<Issue> issues = new List<Issue>();

        public string Id { get => id; set => id = value; }
        public int Total_slot { get => total_slot; set => total_slot = value; }
        public ParkingLotType Type { get => type; set => type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ICollection<Slot> Slots { get => slots; set => slots = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
    }
}
