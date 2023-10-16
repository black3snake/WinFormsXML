using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsXML.DataModel
{
	internal class DataModelContext : DbContext
	{

		public string DbPath { get; }
		public DbSet<Filexml> Filexmls => Set<Filexml>();
		public DataModelContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "helloapp.db");
			Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Data Source={DbPath}");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new FilexmlConfigurations());
		}

		private class FilexmlConfigurations : IEntityTypeConfiguration<Filexml>
		{
			public void Configure(EntityTypeBuilder<Filexml> builder)
			{
				builder.HasKey(e => e.Id);
				builder.Property(e => e.DateReg).HasColumnType("date");
				builder.Property(e => e.PathFileName);
				builder.Property(e => e.Data).HasColumnType("VARBINARY");

			}
		}
	}
}
