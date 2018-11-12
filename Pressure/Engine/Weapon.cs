using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        //Weapon properties.
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        //Weapon constructor with "Item" as base class.
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) 
            : base(id, name, namePlural)
        {
            MinimumDamage   = minimumDamage;
            MaximumDamage   = maximumDamage;
        }
    }
}
