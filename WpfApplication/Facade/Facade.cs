using System;

namespace Facade
{
    public interface IViewModel
    {
    }

    public interface IView
    {
        IViewModel ViewModel { get; set; }
        Type VmType { get; }
    }

    public interface IWrapper
    {

    }
}
