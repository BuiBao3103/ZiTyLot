using System;

namespace ZiTyLot.ENTITY
{
    public class Issue
    {
        //attributes
        private int id;
        private DateTime start_date;
        private DateTime end_date;
        private string license_plate;
        private double fee;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private int? resident_card_id;
        private int? bill_id;
        private int? parking_lot_id;
        private int? slot_id;

        //relationships
        private ResidentCard resident_card = null;
        private Bill bill = null;
        private ParkingLot parking_lot = null;
        private Slot slot = null;

        public int Id { get => id; set => id = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public string License_plate { get => license_plate; set => license_plate = value; }
        public double Fee { get => fee; set => fee = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Resident_card_id { get => resident_card_id; set => resident_card_id = value; }
        public int? Bill_id { get => bill_id; set => bill_id = value; }
        public int? Parking_lot_id { get => parking_lot_id; set => parking_lot_id = value; }
        public int? Slot_id { get => slot_id; set => slot_id = value; }
        public Bill Bill { get => bill; set => bill = value; }
        public ParkingLot Parking_lot { get => parking_lot; set => parking_lot = value; }
        public Slot Slot { get => slot; set => slot = value; }
        internal ResidentCard Resident_card { get => resident_card; set => resident_card = value; }
    }
}
