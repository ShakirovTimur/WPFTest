using Facade;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Model;
using ViewModelBase.Annotations;

namespace ViewModelBase
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public ViewModelBase(Models context)
        {
            if (context == null)
                throw new ArgumentNullException("user factory to create vm");

            Context = context;
        }

        public Models Context { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
