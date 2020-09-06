using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_ConsoleApp.Task4
{
    public class RawMaterial : Item
    {
        public string Size { get; set; }

        public RawMaterial(string size, string name)
        {
            Size = size;
            Name = name;
        }
    }
}
