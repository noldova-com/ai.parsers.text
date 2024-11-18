namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsEndOfText
            => context.CurrentCharacter == context.END_OF_TEXT;

        private void ParseEndOfText()
        {
            // Do nothing for now. We will add an EndOfText special token later.
        }
    }
}