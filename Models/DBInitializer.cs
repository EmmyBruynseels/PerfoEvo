using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfoEvo.Models
{
	public class DBInitializer
	{
		public static void Initialize(PerfoEvoContext context)
		{
			context.Database.EnsureCreated();

			if (context.Gezondheid.Any())
			{
				return;
			}
		}
	}
}
