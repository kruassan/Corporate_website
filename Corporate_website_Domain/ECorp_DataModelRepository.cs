using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Corporate_website_Domain.EntityFramework;
using Corporate_website_Domain.EntityFramework.Models;
using Corporate_website_Domain.EntityFramework.Contexts;

namespace Corporate_website_Domain.EntityFramework
{
	public class ECorp_DataModelRepository : IECorp_DataModelRepository
	{
		private ECorp_DataModelContext context = new ECorp_DataModelContext("public");

		public IQueryable<User> Users()
		{
			return this.context.Users;
		}

		public IQueryable<News> News()
		{
			return this.context.News;
		}
	}
}
