using System.Windows;

namespace DecApp.Commands
{
    public class MsgCommandHandler : BaseCommandHandler<MsgCommand>
    {
        public override bool Handle(MsgCommand command)
        {
            MessageBox.Show(command.Text);
            return true;
        }
    }
}
