namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private void ParseOthers()
        {
            while(!IsWhiteSpace && !IsLineBreak)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}