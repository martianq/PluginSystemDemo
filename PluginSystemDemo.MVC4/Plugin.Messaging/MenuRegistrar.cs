using Griffin.MvcContrib.Plugins;
using PluginSystem.PluginBase;

namespace Plugin.Messaging
{
    /// <summary>
    /// Use Autofacs IStartable to force the registration
    /// </summary>
    public class MenuRegistrar : IMenuRegistrar
    {
        public void Register(IMenuWithChildren mainMenu)
        {
            var item = new RoutedMenuItem("mnuItem", "Messages",
                                          new
                                          {
                                              controller = "Home",
                                              action = "Index",
                                              area = "Messaging"
                                          });
            mainMenu.Add(item);

            //var _itemfi = new RoutedMenuItem("mnuItem", "Finance",
            //                              new
            //                              {
            //                                  controller = "Finance",
            //                                  action = "Index",
            //                                  area = "Financial"
            //                              });
            //mainMenu.Add(_itemfi);
        }
    }
}