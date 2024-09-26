using System;

namespace ZiTyLot.ENTITY
{
    public class ResidentFee
    {
        //Attributes
        private int id;
        private int month;
        private double fee;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private int vehicle_type_id;

        //Relationships
        private VehicleType vehicle_type = null;

        public int Id { get => id; set => id = value; }
        public int Month { get => month; set => month = value; }
        public double Fee { get => fee; set => fee = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int Vehicle_type_id { get => vehicle_type_id; set => vehicle_type_id = value; }
        public VehicleType Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
    }
}
