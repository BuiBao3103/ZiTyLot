using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.ENTITY
{
    public class ResidentCard
    {
        //attributes
        private int id;
        private DateTime due_date;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? card_id;
        private int? resident_id;

        //relationships
        private Card card = null;
        private Resident resident = null;

        public int Id { get => id; set => id = value; }
        public DateTime Due_date { get => due_date; set => due_date = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
        public int? Card_id { get => card_id; set => card_id = value; }
        public int? Resident_id { get => resident_id; set => resident_id = value; }
        public Card Card { get => card; set => card = value; }
        public Resident Resident { get => resident; set => resident = value; }
    }
}
