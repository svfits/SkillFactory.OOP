using System;
using System.Collections.Generic;

namespace SkillFactory.StackandHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack Heap

            UserStack userStack = new UserStack(Age: 30, Mass: 101, Salary: 20000);

            var lsUser = new List<UserClass>();
            for (int i = 0; i < 10000000; i++)
            {
                UserClass userClass = new UserClass(Age: 2 * i, Mass: 10 * i, Salary: 3 * i);
                lsUser.Add(userClass);

                if (i % 100 == 0)
                {
                    Console.WriteLine(userClass.Age);
                    Console.WriteLine(userClass.Mass);
                    Console.WriteLine(userClass.Salary);
                }
            }

            #endregion

            #region Super String сылочный или значемый тип?

            //string str = "SkillFactory.StackandHeap.exe (CoreCLR: clrhost). Загружено C: Program FilesdotnetsharedMicrosoft.NETCore.App3.1.9System.Runtime.InteropServices.dll.Загрузка символов пропущена.Модуль оптимизирован, включен параметр отладчика Только мой код.";

            //foreach (var item in str)
            //{
            //    var strOut = string.Concat(item, " значение в таблице ", (int)item);
            //    Console.WriteLine(strOut);
            //}

            #endregion

            #region Null 

            //UserClass userClass = null;

            //var newAge = userClass.Age;

            #endregion

            #region Unboxing Boxing

            int sum = 1000;

            object obj = sum;

            int j = (int)obj;

            #endregion
            

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
