﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_17RTest
{
	public class Car
	{
		public int CountOfWeel = 4;
		public string Brand;
		private string color = " _ ";
		public string ColorPropertis
		{
			get { return color; }
			set { color = value; }
		}
		public int NumberOfPasagers { get; set; }
		
		public Car()
		{
		}

		public Car(int NumberOfPasagers)
		{
			this.NumberOfPasagers = NumberOfPasagers;
		}

		public Car(int NumberOfPasagers, string Brand)
		{
			this.NumberOfPasagers = NumberOfPasagers;
			this.Brand = Brand;
		}
		public void PresentCar()
		{
			Console.WriteLine($"Hi! I am a {color} car. I can teket {NumberOfPasagers} passagers");
		}

		public string Speed(int distance, int time)
		{
			int speed = distance / time;
			return (speed.ToString() + "km/h");
		}
	}
}