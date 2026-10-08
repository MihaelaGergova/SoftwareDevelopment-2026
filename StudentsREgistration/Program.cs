using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsREgistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Регистрация на ученик===");
            Console.Write("Име:");
            string name = Console.ReadLine();

            //zadacha1
            Console.Write("\nВъзраст:");

            if (int.TryParse(Console.ReadLine(), out int age))
            { 
                Console.WriteLine($"Възраст: {age}"); 
            } 

            else 
            { 
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha2
            Console.Write("\nКлас:");

            if (byte.TryParse(Console.ReadLine(), out byte grade) && grade >= 1 && grade <=12)
            {
                Console.WriteLine($"Клас: {grade}");
            }

            else
            {
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha3
            Console.Write("\nСреден успех:");

            if (double.TryParse(Console.ReadLine(), out double AverageGrades))
            {
                Console.WriteLine($"Среден успех: {AverageGrades}");
            }

            else
            {
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha4
            Console.Write("\nТакса:");

            if (decimal.TryParse(Console.ReadLine(), out decimal tax))
            {
                Console.WriteLine($"Такса: {tax}");
            }

            else
            {
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha5
            Console.Write("\nСтипендия:");

            if (bool.TryParse(Console.ReadLine(), out bool money))
            {
                Console.WriteLine($"Стипендия: {money}");
            }

            else
            {
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha6
            Console.Write("\nПаралелка:");

            if (char.TryParse(Console.ReadLine(), out char group))
            {
                Console.WriteLine($"Паралелка: {group}");
            }

            else
            {
                Console.WriteLine("Невалидни данни.");
            }

            //zadacha7-8
            while (true)
            {
                Console.Write("Дата на раждане: ");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime BirthDate))
                {
                    break;
                }

                Console.WriteLine("Невалидна дата. Опитайте отново.");
            }


        }
    }
}
