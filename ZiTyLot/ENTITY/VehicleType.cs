using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class VehicleType
    {
        //attributes
        private int id;
        private string name;
        private bool has_slot;
        private bool has_vehicle_plate;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private VisitorFee visitor_fee = null;
        private ICollection<Card> cards = new List<Card>();
        private ICollection<ResidentFee> resident_fees = new List<ResidentFee>();
        private ICollection<Issue> issues = new List<Issue>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ICollection<Card> Cards { get => cards; set => cards = value; }
        public ICollection<ResidentFee> Resident_fees { get => resident_fees; set => resident_fees = value; }
        public VisitorFee Visitor_fee { get => visitor_fee; set => visitor_fee = value; }
        public bool Has_slot { get => has_slot; set => has_slot = value; }
        public ICollection<Issue> Issues { get => issues; set => issues = value; }
        public bool Has_vehicle_plate { get => has_vehicle_plate; set => has_vehicle_plate = value; }
    }
}
