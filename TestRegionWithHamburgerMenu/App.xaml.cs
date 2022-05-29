using System.Windows;
using Prism.Ioc;
using TestRegionWithHamburgerMenu.Views;

namespace TestRegionWithHamburgerMenu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
