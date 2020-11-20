using SkillFactory.StartOOP.Library;
using SkillFactory.StartOOP.Library.Extensions;
using System;
using System.Diagnostics;

namespace SkillFactory.StartOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(new NervousSystem(), new Heart())
            {
                Pass = new Pass() { FotoURL = "url", NumberPass = 123 },
                Workplace = new Workplace() { },
            };

            Console.WriteLine(employee.Workplace.WorkplaceId);
            Console.WriteLine(employee.Pass.NumberPass);

            ProductManager productManager = new ProductManager(new NervousSystem(), new Heart())
            {
                Pass = new Pass() { FotoURL = "FotoURL", NumberPass = 1001 }
            };

            Console.WriteLine(productManager.NervousSystemWork("Product manager"));
            Console.WriteLine(productManager.HearWork("Product manager"));

            Console.WriteLine(employee.NervousSystemWork("Employee"));
            Console.WriteLine(employee.HearWork("Employee"));

            ///Extensions
            employee.SaveXMLFile("employee.xml");
            productManager.SaveXMLFile("ProductManager.xml");

            System.IO.File.OpenRead("employee.xml");
            System.IO.File.OpenRead("ProductManager.xml");

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
