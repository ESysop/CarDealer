using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineV1
	{
	class SodaMachine
		{
		GrapeSoda grapeSoda;
		Inventory inventory;
		Soda soda;
		public SodaMachine ()
			{
			grapeSoda = new GrapeSoda();
			}
		public void bootMachine ()
			{
			grapeSoda.fillSodaList();
			Console.ReadKey();
			}
		}
	}
