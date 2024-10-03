using System;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.ENTITY
{
    public class VisitorFee
    {
        //attributes
        private int id;
        private FeeTypeEnum fee_type;
        private double? day_fee;
        private double? night_fee;
        private double? hours_per_turn;
        private int? n_hours;
        private int? m_hours;
        private double? first_n_hours_fee;
        private double? additional_hours_fee;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? vehicle_type_id;

        //relationships
        private VehicleType vehicle_type = null;

        public int Id { get => id; set => id = value; }
        public FeeTypeEnum Fee_type { get => fee_type; set => fee_type = value; }
        public double? Day_fee { get => day_fee; set => day_fee = value; }
        public double? Night_fee { get => night_fee; set => night_fee = value; }
        public double? Hours_per_turn { get => hours_per_turn; set => hours_per_turn = value; }
        public int? N_hours { get => n_hours; set => n_hours = value; }
        public int? M_hours { get => m_hours; set => m_hours = value; }
        public double? First_n_hours_fee { get => first_n_hours_fee; set => first_n_hours_fee = value; }
        public double? Additional_m_hours_fee { get => additional_hours_fee; set => additional_hours_fee = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Vehicle_type_id { get => vehicle_type_id; set => vehicle_type_id = value; }
        public VehicleType Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
    }
}
