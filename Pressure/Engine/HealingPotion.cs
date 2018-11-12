using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        //HealingPotion Properties
        public int AmountToHeal { get; set; }

        //Healing potion constructor with "Item" as base class.
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) 
            : base(id, name, namePlural)
        {
            AmountToHeal    = amountToHeal;
        }
    }
}
