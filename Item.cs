using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item: IComparable
    {
        public string Name { get; set; }

        public Item(string name)
        {
            Name = name;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Item other = obj as Item;

            if (other == null)
            {
                throw new ArgumentException("Please, provide an Item object");
            }

            return Name.CompareTo(other.Name);
        }
    }
}
