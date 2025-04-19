using DotNetNuke.Web.Api;

namespace Bring2mind.TestMvc.TestMvc.Common
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Bring2mind/TestMvc", "TestMvcMap1", "{controller}/{action}", null, null, new[] { "Bring2mind.TestMvc.TestMvc.Api" });
            mapRouteManager.MapHttpRoute("Bring2mind/TestMvc", "TestMvcMap2", "{controller}/{action}/{id}", null, new { id = "-?\\d+" }, new[] { "Bring2mind.TestMvc.TestMvc.Api" });
        }
    }
}