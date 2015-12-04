using Facade;
using Model;
using System;

namespace ViewModelBase
{
    //also we may use Pool to store ViewModels 
    public class VMFactory
    {
        private Models Context { get; set; }

        static VMFactory()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public VMFactory()
        {
            Context = new Models();
            Context.SaveChanges();
        }

        public T CreateVM<T>() where T : IViewModel
        {
            return (T)CreateVM(typeof(T));
        }
        public IViewModel CreateVM(Type type)
        {
            return (IViewModel)Activator.CreateInstance(type, Context);
        }
    }
}
