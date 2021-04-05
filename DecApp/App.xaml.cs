using DecApp.Commands;
using DecApp.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace DecApp
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry container)
        {
            container.Register<ICommandHandler<MsgCommand>, MsgCommandHandler>();
        }
    }
}
