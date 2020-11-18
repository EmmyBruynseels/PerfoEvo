using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfoEvo.Models
{
	public class Gezondheid
	{
		public int Id { get; set; }
		public int OchtendPols { get; set; }
		public int ZuurstofOpname { get; set; }
		public double gewicht { get; set; }
		public string slapengaan{ get; set; }
		public string opstaan { get; set; }
		public DateTime datum{ get; set; }
	}
}
