using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;

namespace TestRegionWithHamburgerMenu.ViewModels;

public class ContentVmBase : AppVmBase, INavigationAware
{
    public virtual bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return false;
    }

    public virtual void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public virtual void OnNavigatedTo(NavigationContext navigationContext)
    {
    }
}
