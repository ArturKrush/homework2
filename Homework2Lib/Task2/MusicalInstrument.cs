using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public abstract class MusicalInstrument
    {
        public string Name { get; private set; }
        public string Characteristics { get; private set; }
        public string Story { get; private set; }

        public MusicalInstrument(string name, string characteristics, string story)
        {
            Name = name;
            Characteristics = characteristics;
            Story = story;
        }
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }
}
