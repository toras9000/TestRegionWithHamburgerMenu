using System;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace TestRegionWithHamburgerMenu.ViewModels;

public class MainWindowViewModel : AppVmBase
{
    public MainWindowViewModel(IRegionManager regionManager)
    {
        this.ChangeContentCommand = new ReactiveCommand<string>()
            .WithSubscribe(v => regionManager.RequestNavigate("MainContentRegion", v), o => o.AddTo(this.Disposables))
            .AddTo(this.Disposables);
    }

    public ReactiveCommand<string> ChangeContentCommand { get; }
}
