using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class VehicleType
    {
        //attributes
        private int id;
        private string name;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        //relationships
        private VisitorFee visitor_fee = null;
        private ICollection<Card> cards = new List<Card>();
        private ICollection<ResidentFee> resident_fees = new List<ResidentFee>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ICollection<Card> Cards { get => cards; set => cards = value; }
        public ICollection<ResidentFee> Resident_fees { get => resident_fees; set => resident_fees = value; }
        public VisitorFee Visitor_fee { get => visitor_fee; set => visitor_fee = value; }
    }
}
