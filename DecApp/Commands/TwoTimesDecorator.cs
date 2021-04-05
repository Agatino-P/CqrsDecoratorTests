using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DecApp.Commands
{
    public class TwoTimesDecorator<TCommand> : BaseCommandHandler<TCommand> where TCommand : ICommand
    {
        private readonly BaseCommandHandler<TCommand> _commandHandler;

        public TwoTimesDecorator(BaseCommandHandler<TCommand> commandHandler)
        {
            _commandHandler = commandHandler;
        }

       
        public override bool Handle(TCommand command)
        {
             for (int i =0;i<2;i++)
            {
                _commandHandler.Handle(command);
            }
            return true;
        }
    }
}
