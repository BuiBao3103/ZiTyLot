using System;

namespace ZiTyLot.ENTITY
{
    public class LostHistory
    {
        //attributes
        private int id;
        private DateTime time_loss;
        private string license_plate;
        private string owner_name;
        private string owner_identification_card;
        private bool is_found;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? card_id;

        //relationships
        private Card card = null;

        public int Id { get => id; set => id = value; }
        public DateTime Time_loss { get => time_loss; set => time_loss = value; }
        public string License_plate { get => license_plate; set => license_plate = value; }
        public string Owner_name { get => owner_name; set => owner_name = value; }
        public string Owner_identification_card { get => owner_identification_card; set => owner_identification_card = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Card_id { get => card_id; set => card_id = value; }
        public Card Card { get => card; set => card = value; }
        public bool Is_found { get => is_found; set => is_found = value; }
    }
}
