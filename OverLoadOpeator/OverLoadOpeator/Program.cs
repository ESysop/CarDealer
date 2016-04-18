using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOpeator
	{
	class Program
		{
		
		static void Main (string[] args)
			{
			//Student me = new Student("12/29/1971");
			//me = me + 7;



			Person person = new Person();
			
			person.getInput();
			
			person.firstName = person.firstName + person.age;
			person.Display();
			Console.ReadLine();

			}

		}
	}
