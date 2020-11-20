using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.StartOOP.Library
{
    public class ProductManager : User
    {
        public ProductManager()
        {

        }

        public ProductManager(NervousSystem nervousSystem, Heart heart) : base(nervousSystem, heart)
        {
        }

        public override Pass Pass { get => base.Pass; set => base.Pass = value; }

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

        public Workplace Workplace { get; set; }

        public override string HearWork(string name)
        {
            return base.HearWork(name);
        }

        public override string NervousSystemWork(string name)
        {
            return base.NervousSystemWork(name);
        }
    }
}
