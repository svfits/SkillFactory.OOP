using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.StackandHeap
{
    /// <summary>
    /// Структура в стэке
    /// </summary>
    struct UserStack
    {
        public UserStack(int Age, int Mass, int Salary)
        {
            this.Age = Age;
            this.Mass = Mass;
            this.Salary = Salary;
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age;

        /// <summary>
        /// Вес
        /// </summary>
        public int Mass;

        /// <summary>
        /// Зарплата
        /// </summary>
        public int Salary;
    }
}
