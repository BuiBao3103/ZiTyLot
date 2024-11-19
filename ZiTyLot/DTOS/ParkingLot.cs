using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.DTOS
{
    public class ParkingLot
    {
        //attributes
        private string id;
        private int total_slot;
        private ParkingLotType parking_lot_type;
        private ParkingLotUserType user_type;
        private ParkingLotStatus status;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private List<Slot> slots = new List<Slot>();
        private List<Issue> issues = new List<Issue>();

        public string Id { get => id; set => id = value; }
        public int Total_slot { get => total_slot; set => total_slot = value; }
        public ParkingLotType Parking_lot_type { get => parking_lot_type; set => parking_lot_type = value; }
        public ParkingLotUserType User_type { get => user_type; set => user_type = value; }
        public ParkingLotStatus Status { get => status; set => status = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public List<Slot> Slots { get => slots; set => slots = value; }
        public List<Issue> Issues { get => issues; set => issues = value; }
    }
}
