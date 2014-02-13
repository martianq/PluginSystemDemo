using System.Web.Routing;

namespace PluginSystem.PluginBase
{
    /// <summary>
    /// Any extra routes (other than the area route)
    /// </summary>
    public interface IRouteRegistrar
    {
        /// <summary>
        /// Register entries
        /// </summary>
        /// <param name="routes">Route to register</param>
        void Register(RouteCollection routes);
    }
}