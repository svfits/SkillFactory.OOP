using System;

namespace SkillFactory.StartOOP.Library
{
    public class Employee
    {
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

        /// <summary>
        /// Пропуск
        /// </summary>
        public Pass Pass { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        public Workplace Workplace { get; set; }
    }
}
