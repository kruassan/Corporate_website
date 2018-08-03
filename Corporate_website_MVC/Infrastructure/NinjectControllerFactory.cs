using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Routing;
using System.Web.Mvc;
using Ninject;

using Moq;
using Corporate_website_Domain.EntityFramework;
using Corporate_website_Domain.EntityFramework.Models;
using Corporate_website_Domain.EntityFramework.Contexts;

using System.Data.Entity;

namespace Corporate_website_MVC
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
			//Mock<IECorp_DataModelContext> mock = new Mock<IECorp_DataModelContext>();
			//mock.Setup(m => m.Users).Returns(new List<User>
			//{
			//	new User()
			//	{
			//		Id = 0, Banned = false, Login = "sanya 1", Pass_hash = "qwerty"
			//	},
			//	new User()
			//	{
			//		Id = 1, Banned = false, Login = "sanya 2", Pass_hash = "ytrewq"
			//	},
			//	new User()
			//	{
			//		Id = 2, Banned = false, Login = "sanya 3", Pass_hash = "asdasd"
			//	}
			//}.AsQueryable());

			//ninjectKernel.Bind<IECorp_DataModelContext>().ToConstant(mock.Object);

			ninjectKernel.Bind<IECorp_DataModelRepository>().To<ECorp_DataModelRepository>();
		}
	}
}
