using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineV1
	{
	public class GrapeSoda : Soda
		{
		Soda unitOfGrapeSoda;
		public int grapeSodaOnHand;
		public List<Soda> grapeSoda;

		public GrapeSoda ()
			{
			unitOfGrapeSoda = new Soda();
			grapeSoda = new List<Soda>();
			}
		public void fillSodaList ()
			{
			for (int i = 0; i < 3; i++)
				{
				grapeSoda.Add(unitOfGrapeSoda);
				}
			}
		}
	}
