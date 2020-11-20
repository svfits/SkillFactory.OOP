﻿using System;

namespace SkillFactory.StartOOP.Library
{
    public class Workplace
    {
        private int workplaceId;

        public Workplace()
        {
            Random random = new Random();
            workplaceId = random.Next(100, 1000);
        }

        public int WorkplaceId
        {
            get
            {
                return workplaceId;
            }
            set
            {
                workplaceId = value;
            }
        }
    }
}