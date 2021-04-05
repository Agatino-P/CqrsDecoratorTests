using DecApp.Commands;
using DecApp.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //container.Register<ICommandHandler<MsgCommand>>(x=> new MsgCommandHandler());
            //container.Register<ICommandHandler<MsgCommand>>(container =>
            //    new TwoTimesDecorator<MsgCommand>(
            //        new TwoTimesDecorator<MsgCommand>(
            //            new MsgCommandHandler()
            //        )
            //    )
            //);
            BaseCommandHandler<MsgCommand> four = new MsgCommandHandler()
                .WrappedIn<TwoTimesDecorator<MsgCommand>>()
                .WrappedIn<TwoTimesDecorator<MsgCommand>>();
            container.Register<BaseCommandHandler<MsgCommand>>(() => four);
                
            
        }

    }                                             

}
