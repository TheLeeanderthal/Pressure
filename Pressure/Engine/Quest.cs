﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        //Quest Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        //Quest constructor
        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID                      = id;
            Name                    = name;
            Description             = description;
            RewardExperiencePoints  = rewardExperiencePoints;
            RewardGold              = rewardGold;

            //List property to hold quest reward items
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}