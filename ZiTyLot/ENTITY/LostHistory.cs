using System;

namespace ZiTyLot.ENTITY
{
    public class LostHistory
    {
        private int id;
        private DateTime time_loss;
        private string vehicle_plate;
        private string owner_name;
        private string owner_identification_card;
        private DateTime created_at;
        private DateTime updated_at;
        private DateTime deleted_at;
        private Card card;

        public int Id { get => id; set => id = value; }
        public DateTime TimeLoss { get => time_loss; set => time_loss = value; }
        public string VehiclePlate { get => vehicle_plate; set => vehicle_plate = value; }
        public string OwnerName { get => owner_name; set => owner_name = value; }
        public string OwnerIdentificationCard { get => owner_identification_card; set => owner_identification_card = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Card Card { get => card; set => card = value; }
    }
}
