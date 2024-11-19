using System;
using ZiTyLot.Constants.Enum;

namespace ZiTyLot.DTOS
{
    public class Image
    {
        //attributes
        private int id;
        private string url;
        private ImageType type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;

        private int? session_id;

        //relationships
        private Session session = null;

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
       
        public Session Session { get => session; set => session = value; }
        public int? Session_id { get => session_id; set => session_id = value; }
        public ImageType Type { get => type; set => type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime? Updated_at { get => updated_at; set => updated_at = value; }
        public DateTime? Deleted_at { get => deleted_at; set => deleted_at = value; }
    }
}
