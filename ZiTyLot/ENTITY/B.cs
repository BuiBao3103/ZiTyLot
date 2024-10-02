using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.ENTITY
{
    public class B
    {
        private string id;
        private string name;
        private int a_id;
        private A a = null;

        public string Name { get => name; set => name = value; }
        public int A_id { get => a_id; set => a_id = value; }
        public A A { get => a; set => a = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, A_id: {A_id}, A: {A}";
        }
    }
}

