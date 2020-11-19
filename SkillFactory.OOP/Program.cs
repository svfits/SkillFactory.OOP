using System;

namespace SkillFactory.OOP.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Простой метод

            //for (int i = 0; i < 10; i++)
            //{
            //    var summ = ValueI(i);
            //    Console.WriteLine(summ);
            //}

            #endregion

            #region Parametr OUT

            //Console.WriteLine("Введите число:");
            //string strInt = Console.ReadLine();
            //var ifInt = int.TryParse(strInt, out int result);

            //if (ifInt)
            //{
            //    Console.WriteLine($"Было введено число { result }");
            //}
            //else
            //{
            //    Console.WriteLine($"Было введено точно не Int");
            //}

            #endregion

            #region StackOverflowException

            //StackOverflowException(1000);

            #endregion

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        /// <summary>
        /// Метод котрый должен вызвать исключение т.к он заполнит весь стэк
        /// </summary>
        /// <param name="Number"></param>
        static void StackOverflowException(int Number)
        {
            Console.WriteLine(DateTime.Now);
            StackOverflowException(Number);
        }

        #region Простой метод 

        /// <summary>
        /// Вывод на консоль переменной I и возведение в квадрат
        /// </summary>
        /// <param name="i">Переменная i</param>
        private static int ValueI(int i)
        {
            Console.WriteLine($"Пришла переменная i = { i }");
            return i * i;
        }

        #endregion
    }
}
