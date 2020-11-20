using System;

namespace SkillFactory.StartOOP.Library
{
    public class Workplace
    {
        private readonly int workplaceId;

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
        }
    }
}