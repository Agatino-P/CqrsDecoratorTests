using System;
using System.Linq;
using System.Reflection;

namespace DecApp.Commands
{
    public abstract class BaseCommandHandler<TCommand> where TCommand : ICommand
    {
        public abstract bool Handle(TCommand command);

        public TWrapper WrappedIn<TWrapper>() where TWrapper : BaseCommandHandler<TCommand>
        {
            Type wrapperType = typeof(TWrapper).GetGenericTypeDefinition();
            Type[] typeArgs = { typeof(TCommand) };
            Type fullWrapperType = wrapperType.MakeGenericType(typeArgs);
            ConstructorInfo genericConstructorInfo = fullWrapperType.GetConstructors().Single();

            return (TWrapper)genericConstructorInfo.Invoke(new object[] { this });
        }
        

    }
}
