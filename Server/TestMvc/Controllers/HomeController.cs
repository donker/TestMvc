using System.Web.Mvc;
using Bring2mind.TestMvc.TestMvc.Common;

namespace Bring2mind.TestMvc.TestMvc.Controllers
{
    public class HomeController : TestMvcMvcController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(TestMvcModuleContext.Settings.View);
        }
    }
}
