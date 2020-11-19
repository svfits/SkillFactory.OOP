using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.StackandHeap
{
    /// <summary>
    /// Находится в куче(Heap)
    /// </summary>
    class UserClass
    {
        public UserClass(int Age, int Mass, int Salary)
        {
            this.Age = Age;
            this.Mass = Mass;
            this.Salary = Salary;
        }

        public int Age { get; private set; }

        /// <summary>
        /// Вес
        /// </summary>
        public int Mass;

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary;

        public int SumSalaryYears(int year)
        {
            return Salary * year;
        }
    }
}
