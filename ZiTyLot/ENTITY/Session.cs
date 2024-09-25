using System;
using System.Collections.Generic;

namespace ZiTyLot.ENTITY
{
    public class Session
    {
        private int id;
        private string vehicle_plate;
        private DateTime checkin_time;
        private DateTime checkout_time;
        private double price;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private Card card;
        private ICollection<Image> images = new List<Image>();

        public int Id { get => id; set => id = value; }
        public string VehiclePlate { get => vehicle_plate; set => vehicle_plate = value; }
        public DateTime CheckinTime { get => checkin_time; set => checkin_time = value; }
        public DateTime CheckoutTime { get => checkout_time; set => checkout_time = value; }
        public double Price { get => price; set => price = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Card Card { get => card; set => card = value; }
        public ICollection<Image> Images { get => images; set => images = value; }
    }
}
