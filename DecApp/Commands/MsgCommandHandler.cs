using System.Windows;

namespace DecApp.Commands
{
    public class MsgCommandHandler : ICommandHandler<MsgCommand>
    {
        public bool Handle(MsgCommand command)
        {
            MessageBox.Show(command.Text);
            return true;
        }
    }
}
