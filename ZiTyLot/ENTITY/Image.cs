using System;

namespace ZiTyLot.ENTITY
{
    public class Image
    {
        private int id;
        private string url;
        private ImageType image_type;
        private DateTime created_at;
        private DateTime? updated_at;
        private DateTime? deleted_at;
        private Session session;

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public ImageType ImageType { get => image_type; set => image_type = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public DateTime? UpdatedAt { get => updated_at; set => updated_at = value; }
        public DateTime? DeletedAt { get => deleted_at; set => deleted_at = value; }
        public Session Session { get => session; set => session = value; }
    }
}
