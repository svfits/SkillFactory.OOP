using SkillFactory.StartOOP.Library;
using System;

namespace SkillFactory.StartOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var emploee = new Employee() 
            {
                Pass = new Pass() { FotoURL = "url", NumberPass = 123 },
                Salary = 122333,
                Workplace = new Workplace(),
            };

            Console.WriteLine(emploee.Workplace.WorkplaceId);
            Console.WriteLine(emploee.Pass.NumberPass);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
