using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Session
    {
        //attributes
        private int id;
        private string license_plate;
        private DateTime checkin_time;
        private DateTime checkout_time;
        private double fee;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? card_id;

        //relationships
        private Card card = null;
        private ICollection<Image> images = new List<Image>();

        public int Id { get => id; set => id = value; }
        public string License_plate { get => license_plate; set => license_plate = value; }
        public DateTime Checkin_time { get => checkin_time; set => checkin_time = value; }
        public DateTime Checkout_time { get => checkout_time; set => checkout_time = value; }
        public double Fee { get => fee; set => fee = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Card_id { get => card_id; set => card_id = value; }
        public Card Card { get => card; set => card = value; }
        public ICollection<Image> Images { get => images; set => images = value; }
    }
}
