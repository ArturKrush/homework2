using Homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework2Lib
{
    public class Violin: MusicalInstrument
    {
        public Violin(string name, string characteristics, string story)
            : base(name, characteristics, story) { }

        public override void Show()
        {
            Console.WriteLine(Name); 
        }
        public override void Desc()
        {
            Console.WriteLine(Characteristics);
        }
        public override void History()
        {
            Console.WriteLine(Story);
            Console.WriteLine("--------");
        }
    }
}
