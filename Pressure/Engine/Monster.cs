using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        //Monster properties
        public string Name { get; set; }
        public int ID { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        //Monster constructor with "LivingCreature" as base class
        public Monster (int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, 
            int currentHitPoints, int maximumHitPoints) 
            : base(currentHitPoints, maximumHitPoints)
        {
            ID                      = id;
            Name                    = name;
            MaximumDamage           = maximumDamage;
            RewardExperiencePoints  = rewardExperiencePoints;
            RewardGold              = rewardGold;

            //List property to hold monster loot
            LootTable = new List<LootItem>();
        }
    }
}
