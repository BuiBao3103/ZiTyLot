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

        private int? bill_id;
        private int? vehicle_type_id;
        private string parking_lot_id;
        private string slot_id;

        //relationships
        private Bill bill = null;
        private VehicleType vehicle_type = null;
        private ParkingLot parking_lot = null;
        private Slot slot = null;
        private Card card = null;

        public int Id { get => id; set => id = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public string License_plate { get => license_plate; set => license_plate = value; }
        public double Fee { get => fee; set => fee = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Bill_id { get => bill_id; set => bill_id = value; }
        public int? Vehicle_type_id { get => vehicle_type_id; set => vehicle_type_id = value; }
        public string Parking_lot_id { get => parking_lot_id; set => parking_lot_id = value; }
        public string Slot_id { get => slot_id; set => slot_id = value; }
        public Bill Bill { get => bill; set => bill = value; }
        public VehicleType Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
        public ParkingLot Parking_lot { get => parking_lot; set => parking_lot = value; }
        public Slot Slot { get => slot; set => slot = value; }
        public Card Card { get => card; set => card = value; }
    }
}
