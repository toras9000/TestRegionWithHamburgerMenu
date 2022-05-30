using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace TestRegionWithHamburgerMenu.ViewModels;

public class AppVmBase : BindableBase, IDisposable
{
    public AppVmBase()
    {
        this.Disposables = new CompositeDisposable();
    }

    public bool IsDisposed { get; private set; }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected CompositeDisposable Disposables { get; }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.IsDisposed)
        {
            if (disposing)
            {
                this.Disposables.Dispose();
            }

            this.IsDisposed = true;
        }
    }
}
