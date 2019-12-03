﻿using System;

namespace Stage1Paragraph10
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Елена Петрова", new DateTime(1990, 04, 05),
                "ПМР, г. Каменка", 45786125);
            Person person2 = new Person("Елена Петрова", new DateTime(1990, 04, 05),
                "ПМР, г. Каменка", 45786125);

            Console.WriteLine($"Тест метода Equals():{person1.Equals(person2)}");
            Console.WriteLine($"Тест метода GetHashCode(): {person1.GetHashCode() == person2.GetHashCode()}");
            Console.WriteLine($"Тест оператора ==: {person1 == person2}");

            person2.Name = "Елена Борисова";

            Console.WriteLine($"Тест метода Equals():{person1.Equals(person2)}");
            Console.WriteLine($"Тест метода GetHashCode(): {person1.GetHashCode() == person2.GetHashCode()}");
            Console.WriteLine($"Тест оператора ==: {person1 == person2}");

            Console.ReadLine();
        }
    }
}