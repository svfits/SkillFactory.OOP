using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.StartOOP.Library
{
    public sealed class  Developer : User
    {
        public static int SumSalary;

        static Developer()
        {
            SumSalary = 10;
        }

        public Developer(NervousSystem nervousSystem, Heart heart) : base(nervousSystem, heart)
        {

        }

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary
        {
            get
            {
                Random random = new Random();
                return random.Next(1000, 9999);
            }
        }
    }
}
