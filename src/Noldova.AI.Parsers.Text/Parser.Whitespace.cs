namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsWhiteSpace
            => char.IsWhiteSpace(context.CurrentCharacter);

        private void ParseWhiteSpaces()
        {
            while(IsWhiteSpace)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}