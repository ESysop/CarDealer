using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOpeator
	{
	class Person
		{
		public string firstName, lastName,birthDay;
		public int currentAge, adjustedAge, amountToAdjust, year, month, day;
		DateTime dateTime;


		public Person ()
			{
			dateTime = new DateTime();
		
			}
		public void askDate ()
			{
			Console.WriteLine("Enter your birthdate" );
			birthDay = Console.ReadLine();
			dateTime = Convert.ToDateTime(birthDay);
			Console.WriteLine(dateTime.ToShortDateString());
			Console.ReadLine();
			}
		

		}
	}
	
