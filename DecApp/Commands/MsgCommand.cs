namespace DecApp.Commands
{
    public class MsgCommand : ICommand
    {
        public MsgCommand(string text) 
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
