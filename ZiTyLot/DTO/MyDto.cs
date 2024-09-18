namespace ZiTyLot
{
    public class MyDTO
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        // Add other properties as needed

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }

}
