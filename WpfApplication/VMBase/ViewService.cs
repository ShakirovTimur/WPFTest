using Facade;
using System;
using ViewModelBase;

namespace VMBase
{
    public class ViewService
    {
        VMFactory vmFactory;

        public ViewService()
        {
            vmFactory = new VMFactory();
        }

        public T CreateView<T>() where T : IView
        {
            var res = (T)Activator.CreateInstance(typeof(T), this);
            res.ViewModel = vmFactory.CreateVM(res.VmType);
            return res;
        }
        public IView NextView { get; set; }
    }
}