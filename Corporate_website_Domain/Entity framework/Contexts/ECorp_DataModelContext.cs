using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Corporate_website_Domain.EntityFramework;
using Corporate_website_Domain.EntityFramework.Models;

namespace Corporate_website_Domain.EntityFramework.Contexts
{
	public class ECorp_DataModelContext : DbContext
	{
		private string schema;

		public ECorp_DataModelContext(string schema) : base("AppDatabaseConnectionString")
		{
			this.schema = schema;
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.HasDefaultSchema(this.schema);
			base.OnModelCreating(builder);
		}

		public DbSet<User> Users { get; set; }

		public DbSet<News> News { get; set; }
	}
}