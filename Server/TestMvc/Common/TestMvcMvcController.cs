using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Web.Mvc.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bring2mind.TestMvc.TestMvc.Common
{
    public class TestMvcMvcController : DnnController
    {

        private ContextHelper _TestMvcModuleContext;
        public ContextHelper TestMvcModuleContext
        {
            get { return _TestMvcModuleContext ?? (_TestMvcModuleContext = new ContextHelper(this)); }
        }

    }
}