using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TestRegionWithHamburgerMenu.Views;

namespace TestRegionWithHamburgerMenu.Modules;

public class MainContentNavigator : IModule
{
    public MainContentNavigator(IRegionManager regionMngr)
    {
        this.regionManager = regionMngr;
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<ViewA>();
        containerRegistry.RegisterForNavigation<ViewB>();
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        this.regionManager.RequestNavigate("MainContentRegion", "ViewA");
    }

    private IRegionManager regionManager;
}
