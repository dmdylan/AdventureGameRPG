using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureRPG_Classes
{
    public class Player
    {
        //private int health;
        //private int armor;
        //private int attackDamage;
        //public string name;
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }

    }
    
}
