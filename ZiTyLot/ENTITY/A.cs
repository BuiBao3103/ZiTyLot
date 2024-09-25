using System.Collections;
using System.Collections.Generic;
namespace ZiTyLot.ENTITY
{
    public class A
    {
        private int id;
        private string name;
        private ICollection<B> bs = new List<B>();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ICollection<B> Bs { get => bs; set => bs = value; }

        public override string ToString()
        {
            return $"A: {Id} - {Name}";
        }
    }

}
    