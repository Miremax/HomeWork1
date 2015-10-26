using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какого возраста кошку Вы желаете?");
            int age1;
            age1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine(age1);
            var cat1 = new Cat(age1);
           // Console.WriteLine(cat1.Age);
            int k = 1;
            while (k == 1)
            {
                Console.WriteLine(" - Имя кошки " + cat1.Name + "\n - Возраст " + cat1.Age + " \n - Цвет "+cat1.CurrentColor);
                Console.WriteLine("Выберите дальнейшие действия:");
                Console.WriteLine("Нажмите 1 для выбора клички (имейте в виду, это можно сделать только один раз)\nНажмите 2 для выбора цвета кошки\nНажмите 3 для наказания кошки\nНажмите 4 чтобы ее покормить");
                int a1;
                a1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(a1);
                if (a1 == 1)
                {
                    Console.WriteLine("Вводите кличку");
                    cat1.Name = Console.ReadLine();
                }
                if (a1 == 2)
                {
                    Console.WriteLine("Для введения цвета здоровой довольной кошки нажмите 1. Больной 2.");
                    a1 = int.Parse(Console.ReadLine());
                    if (a1 == 1)
                    {
                        cat1.Color.HealthyColor = Console.ReadLine();
                    }
                    else if (a1 == 2)
                        {
                            cat1.Color.SickColor = Console.ReadLine();
                        }
                }
                if (a1 == 3)
                {
                   cat1.Punish();
                }
                if (a1 == 4)
                {
                    cat1.Feed();
                }
                // Console.WriteLine(Cat1.CurrentColor);
                //  Console.WriteLine(Cat1.Name);

            }
            Console.ReadKey();
        }
    }
}
