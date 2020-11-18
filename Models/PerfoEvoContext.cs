using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfoEvo.Models
{
	public class PerfoEvoContext :  DbContext
	{
		public PerfoEvoContext(DbContextOptions<PerfoEvoContext> options) : base(options)
		{

		}
		public DbSet<Gezondheid> Gezondheid { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Gezondheid>().ToTable("tabelGezondheid");
		}
	}
}
