using System;

namespace ZiTyLot.ENTITY
{
    public class VisitorPrice
    {
        private int id;
        private double parking_lot_fees;
        private bool isday;
        private double hours_per_visit;
        private double first_n_hours;
        private double additional_hours;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private VehicleType vehicle_type;

        public int Id { get => id; set => id = value; }
        public double ParkingLotFees { get => parking_lot_fees; set => parking_lot_fees = value; }
        public bool IsDay { get => isday; set => isday = value; }
        public double HoursPerVisit { get => hours_per_visit; set => hours_per_visit = value; }
        public double FirstNHours { get => first_n_hours; set => first_n_hours = value; }
        public double AdditionalHours { get => additional_hours; set => additional_hours = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime? UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime? DeletedAt { get => deleted_at; set => deleted_at = value; }
        public VehicleType VehicleType { get => vehicle_type; set => vehicle_type = value; }
    }
}
