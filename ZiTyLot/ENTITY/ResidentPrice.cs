using System;

namespace ZiTyLot.ENTITY
{
    public class ResidentPrice
    {
        private int id;
        private int month;
        private double price;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private VehicleType vehicle_type;

        public int Id { get => id; set => id = value; }
        public int Month { get => month; set => month = value; }
        public double Price { get => price; set => price = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime? UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime? DeletedAt { get => deleted_at; set => deleted_at = value; }
        public VehicleType VehicleType { get => vehicle_type; set => vehicle_type = value; }
    }
}
