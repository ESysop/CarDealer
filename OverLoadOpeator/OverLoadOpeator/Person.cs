using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOpeator
	{
	class Person
		{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public DateTime BirthDay { get; set; }
		public string firstName, lastName;
		public int currentAge, adjustedAge, amountToAdjust, year, month, age, day;
		DateTime birthDate;
	

		public Person ()
			{
				
			}
		public Person (String Birthday)
			{
			this.BirthDay = DateTime.Parse(Birthday);
			this.Age = (DateTime.Today.Subtract(this.BirthDay).Days / 365)
;
			}
	
		

		public void getInput ()
				{

			Console.WriteLine("Enter your birthdate" );
			birthDate = Convert.ToDateTime( Console.ReadLine());
			age = CalculateAge(birthDate);

						
				Console.WriteLine("Enter Years to Adjust");
				amountToAdjust = Convert.ToInt32(Console.ReadLine());
				
				}
			public int CalculateAge (DateTime birthDate)
				{
				DateTime today = DateTime.Today;
	
				int age = today.Year - birthDate.Year;
				if (birthDate.AddYears(age) > today)
					{
					age--;
					}
				return age;
				}
		public static Person operator +( Person firstName, int age)
			{
			firstName = firstName + age;
			return firstName;
			}
		public void Display ()
			{

			Console.WriteLine("the age is: " + age);
			Console.WriteLine("Your age will be: " + (firstName+amountToAdjust));

			}
		}

	}
	
	
