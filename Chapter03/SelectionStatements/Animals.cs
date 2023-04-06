using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Animal //base type for all animals
    {
        public string? Name;
        public DateTime Born;
        public byte Legs;
    }

    class Cat : Animal //subtype of Animal
    {
        public bool IsDomestic;
    }

    class Spider : Animal //another subtype of Animal
    {
        public bool IsPoisonous;
    }
}
