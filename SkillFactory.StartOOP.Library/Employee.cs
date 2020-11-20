using System;

namespace SkillFactory.StartOOP.Library
{
    public sealed class Employee : User
    {
        /// <summary>
        /// Сумма всех зарплат сотрудников
        /// </summary>
        private static readonly int SumSalary;

        static Employee()
        {
            SumSalary = 10;
        }

        public Employee(NervousSystem nervousSystem, Heart heart) : base(nervousSystem, heart)
        {

        }

        public Employee()
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

        public override Pass Pass { get; set; }

        public Workplace Workplace { get; set; }

        public override string HearWork(string name)
        {
            return base.HearWork(name);
        }

        public override string NervousSystemWork(string name)
        {
            return base.NervousSystemWork(name);
        }

        /// <summary>
        /// Перегрузка операторов
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="employee1"></param>
        /// <returns></returns>
        public static Employee operator +(Employee employee, Employee employee1)
        {
            return new Employee()
            {
                Pass = new Pass() { NumberPass = employee.Pass.NumberPass + employee1.Pass.NumberPass }
            };
        }
    }
}
