using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Corporate_website_Domain.EntityFramework.Models;
using Corporate_website_Domain.EntityFramework.Contexts;

namespace Corporate_website_Domain.EntityFramework
{
	public interface IECorp_DataModelRepository
	{
		IQueryable<User> Users();

		IQueryable<News> News();
	}
}
