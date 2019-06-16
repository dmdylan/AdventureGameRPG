using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureRPG_Classes
{
    public class Item
    {
        public int Value { get; set; }
        public int ItemType { get; set; }
        public string Name { get; set; }

        public Item(string name, int itemType, int value)
        {
            Value = value;
            ItemType = itemType;
            Name = name;
        }
    }
}
