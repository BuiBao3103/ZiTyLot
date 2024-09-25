using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Card
    {
        private int id;
        private string rfid;
        private CardStatus status;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private VehicleType vehicle_type;
        private ICollection<Issue> issues = new List<Issue>();
        private ICollection<Session> sessions = new List<Session>();
        private ICollection<LostHistory> lostHistories = new List<LostHistory>();

        public int Id { get => id; set => id = value; }
        public string Rfid { get => rfid; set => rfid = value; }
        public CardStatus Status { get => status; set => status = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public VehicleType VehicleType { get => vehicle_type; set => vehicle_type = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
        public ICollection<Session> Sessions { get => sessions; set => sessions = value; }
        public ICollection<LostHistory> LostHistories { get => lostHistories; set => lostHistories = value; }
    }
}
