﻿using System;
using Newtonsoft.Json;

namespace Topic_18_Serializing_a_cyclic_object_
{
	class Program
	{
		static void Main(string[] args)
		{
			// объект для сериализации			
			Person person = new Person();
			person.Name = "Ivan";
			person.PassportNumber = 123323;

			string json = JsonConvert.SerializeObject(person);
			Console.WriteLine("Объект серриализован.");
			Console.WriteLine(json);
			Person person1 = JsonConvert.DeserializeObject<Person>(json);
			Console.WriteLine("Объект десерриализован.");
			Console.WriteLine($"Name = {person1.Name}");
		}
	}
}