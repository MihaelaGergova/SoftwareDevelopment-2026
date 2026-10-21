using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationHW
{
    internal class Program
    {
        private static int nextId = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Регистрация на ученик ===");

            // 1.Name
            string name = string.Empty;
            while (true)
            {
                Console.Write("Име: ");
                try
                {
                    name = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name))
                        throw new ArgumentException("Името не може да бъде празно или само интервали.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}. Въведете отново.");
                }
            }


            Student student = null;
            try
            {
                student = new Student(nextId++, name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка при създаване: {ex.Message}");
                return;
            }

            // 2.Age
            while (true)
            {
                Console.Write("Възраст: ");
                try
                {
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        student.Age = age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден формат за цяло число.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 3.Grade
            while (true)
            {
                Console.Write("Клас: ");
                try
                {
                    if (int.TryParse(Console.ReadLine(), out int grade))
                    {
                        student.Grade = grade;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден формат за клас.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 4.AverageScore
            while (true)
            {
                Console.Write("Среден успех: ");
                try
                {
                    if (double.TryParse(Console.ReadLine(), out double avgScore))
                    {
                        student.AverageScore = avgScore;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден формат за успех.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 5.Fee
            while (true)
            {
                Console.Write("Такса: ");
                try
                {
                    if (decimal.TryParse(Console.ReadLine(), out decimal fee))
                    {
                        student.Fee = fee;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден формат за такса.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 6.HasScholarship
            while (true)
            {
                Console.Write("Получава ли стипендия (true/false): ");
                try
                {
                    if (bool.TryParse(Console.ReadLine(), out bool scholarship))
                    {
                        student.HasScholarship = scholarship;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Моля въведете true или false.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 7.ClassLetter
            while (true)
            {
                Console.Write("Паралелка: ");
                try
                {
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && char.TryParse(input, out char letter))
                    {
                        student.ClassLetter = letter;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Моля въведете точно един символ (буква).");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }

            // 8.BirthDate
            while (true)
            {
                Console.Write("Дата на раждане (MM.dd.yyyy): ");
                try
                {
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                    {
                        student.BirthDate = birthDate;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден формат за дата.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message}");
                }
            }


            Console.WriteLine();
            Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Име: {student.Name}");
            Console.WriteLine($"Възраст: {student.Age}");
            Console.WriteLine($"Клас: {student.Grade}");
            Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
            Console.WriteLine($"Такса: {student.Fee:F2} лв.");
            Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "Не")}");
            Console.WriteLine($"Паралелка: {student.ClassLetter}");
            Console.WriteLine($"Дата на раждане: {student.BirthDate:dd.MM.yyyy}");

        }
    }
}
