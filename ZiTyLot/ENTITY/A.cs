using System.Collections;
using System.Collections.Generic;
using ZiTyLot.Constants.Enum;
namespace ZiTyLot.ENTITY
{
    public class A
    {
        private int id;
        private string name;
        private AType type;
        private ICollection<B> bs = new List<B>();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public ICollection<B> Bs { get => bs; set => bs = value; }
        public AType Type { get => type; set => type = value; }

        public override string ToString()
        {
           return $"Id: {Id}, Name: {Name}, Type: {type} Bs: [{string.Join("; ", Bs)}]";
        }
    }

}
    