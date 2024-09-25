using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class VehicleType
    {
        private int id;
        private string name;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private ICollection<Card> cards = new List<Card>();
        private ICollection<ResidentPrice> resident_prices = new List<ResidentPrice>();
        private ICollection<VisitorPrice> visitor_prices = new List<VisitorPrice>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public ICollection<Card> Cards { get => cards; set => cards = value; }
        public ICollection<ResidentPrice> ResidentPrices { get => resident_prices; set => resident_prices = value; }
        public ICollection<VisitorPrice> VisitorPrices { get => visitor_prices; set => visitor_prices = value; }

    }
}
