using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TestRegionWithHamburgerMenu.Modules;
using TestRegionWithHamburgerMenu.Views;

namespace TestRegionWithHamburgerMenu;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<MainContentNavigator>();
    }

    protected override Window CreateShell()
    {
        var regionManager = this.Container.Resolve<IRegionManager>();
        regionManager.Regions.CollectionChanged += (s, a) =>
        {
            System.Diagnostics.Debug.WriteLine($"Regions: Action={a.Action}");
        };

        return Container.Resolve<MainWindow>();
    }
}
