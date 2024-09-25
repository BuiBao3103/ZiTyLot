using System;

namespace ZiTyLot.ENTITY
{
    public class Issue
    {
        private int id;
        private DateTime start_date;
        private DateTime end_date;
        private string vehicle_plate;
        private double price;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private Bill bill;
        private Slot slot;
        private ParkingLot parking_lot;
        private Card card;

        public int Id { get => id; set => id = value; }
        public DateTime StartDate { get => start_date; set => start_date = value; }
        public DateTime EndDate { get => end_date; set => end_date = value; }
        public string VehiclePlate { get => vehicle_plate; set => vehicle_plate = value; }
        public double Price { get => price; set => price = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Bill Bill { get => bill; set => bill = value; }
        public Slot Slot { get => slot; set => slot = value; }
        public ParkingLot ParkingLot { get => parking_lot; set => parking_lot = value; }
        public Card Card { get => card; set => card = value; }
    }
}
