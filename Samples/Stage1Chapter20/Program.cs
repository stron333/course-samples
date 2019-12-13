﻿using System;
using System.Collections.Generic;

namespace Stage1Chapter20
{
    class Program
    {
        static void Main()
        {
            RegularExpression regExp = new RegularExpression();

            // 1 
            Console.WriteLine("Введите адрес электронной почты");
            string email = Console.ReadLine();

            regExp.IsEmailInfo( regExp.IsEmail(email) );

            // 2
            string numberExp = "(1, 1000, 1 000 000, 100.23)";
            Console.WriteLine($"Разбор строки {numberExp}:");
            List<string> listNumExp = regExp.NumberExpression(numberExp);
            foreach (var s in listNumExp)
            {
                Console.WriteLine($"Число: {s}");
            }
            Console.ReadLine();

            // 3
            Console.WriteLine("Введите номер телефона");
            string tel = Console.ReadLine();

            regExp.IsTelephoneInfo(regExp.IsTelephone(tel));
        }
    }
}