using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Routing;
using Ninject;

using Moq;
using Corporate_website_Domain.EntityFramework;
using Corporate_website_Domain.EntityFramework.Models;
using Corporate_website_Domain.EntityFramework.Contexts;

namespace Corporate_website_MVC.Controllers
{
    public class CatalogController : Controller
    {
		private IECorp_DataModelRepository dataModelContext;

		public CatalogController(IECorp_DataModelRepository _DataModelContext)
		{
			this.dataModelContext = _DataModelContext;
		}

		public ViewResult Products()
		{
			return View(dataModelContext.Users());
		}
	}
}