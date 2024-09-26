using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Card
    {
        //attributes
        private int id;
        private string rfid;
        private string status;
        private string type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private string vehicle_type_id;

        //relationships
        private VehicleType vehicle_type = null;
        private ICollection<Session> sessions = new List<Session>();
        private ICollection<LostHistory> lost_histories = new List<LostHistory>();
        //if type == "RESIDENT"
        private ResidentCard resident_card = null;

        public int Id { get => id; set => id = value; }
        public string Rfid { get => rfid; set => rfid = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public string Vehicle_type_id { get => vehicle_type_id; set => vehicle_type_id = value; }
        public VehicleType Vehicle_type { get => vehicle_type; set => vehicle_type = value; }
        public ICollection<Session> Sessions { get => sessions; set => sessions = value; }
        public ICollection<LostHistory> Lost_histories { get => lost_histories; set => lost_histories = value; }
        public ResidentCard Resident_card { get => resident_card; set => resident_card = value; }
    }
}
