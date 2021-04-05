using DecApp.Commands;
using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DecApp.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        private readonly IContainerProvider _container;

        public ShellWindowViewModel(IContainerProvider container)
        {
            TestCmd = new(test);
            _container = container;
        }

        public DelegateCommand TestCmd { get; private set; }
        private void test()
        {
            MsgCommand command = new("stringa1");
            ICommandHandler < MsgCommand > handler = _container.Resolve<ICommandHandler<MsgCommand>>();
            handler.Handle(command);

        }


    }
}
