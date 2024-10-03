using System;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.ENTITY
{
    public class Card
    {
        //attributes
        private int id;
        private string rfid;
        private CardStatus status;
        private CardType type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int vehicle_type_id;
        private int resident_id;

        //relationships
        private VehicleType vehicle_type = null;
        private Resident resident = null;
        private ICollection<Issue> issues = new List<Issue>();
        private ICollection<Session> sessions = new List<Session>();
        private ICollection<LostHistory> lost_histories = new List<LostHistory>();

        public int Id { get => id; set => id = value; }
        public string Rfid { get => rfid; set => rfid = value; }
        public CardStatus Status { get => status; set => status = value; }
        public CardType Type { get => type; set => type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int Vehicle_type_id { get => vehicle_type_id; set => vehicle_type_id = value; }
        public int Resident_id { get => resident_id; set => resident_id = value; }
        public VehicleType Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
        public Resident Resident { get => resident; set => resident = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
        public ICollection<Session> Sessions { get => sessions; set => sessions = value; }
        public ICollection<LostHistory> Lost_histories { get => lost_histories; set => lost_histories = value; }
    }
}
