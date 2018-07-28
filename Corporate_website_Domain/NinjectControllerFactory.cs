using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Routing;
using System.Web.Mvc;
using Ninject;


namespace Corporate_website_Domain
{
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel ninjectKernel;

		public NinjectControllerFactory()
		{
			//creating container
			ninjectKernel = new StandardKernel();
			AddBindings();
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			//controller from container by his type
			return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
		}
		
		private void AddBindings()
		{
			//configure container
		}
	}
}
