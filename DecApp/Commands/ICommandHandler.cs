using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecApp.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        public bool Handle(TCommand command);
    }
}
