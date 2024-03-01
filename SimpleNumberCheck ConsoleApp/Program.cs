using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumberCheck_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.WriteLine("Приветствую! Введите целое число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine()); // ushort - чтобы сэкономить место

            int i = 1; // объявила переменную-счетчик, в нее далее поместим результат деления;
            int j = 0; // переменная под результат деления;

            bool complexNumber = true;
            complexNumber = userNumber % i == 0; // если результат = 0, сложное число (истина)
           
            while (i != (userNumber - 1)) 
            {
                i++;

                if (userNumber%i == 0)
                {
                    j = 1;
                }

            }

            if (j == 1)
            {
                Console.WriteLine($"Число {userNumber} является сложным!");
            }
            else
            {
                Console.WriteLine($"Число {userNumber} является простым!");
            }

            Console.ReadKey();
        }
    }
} 
