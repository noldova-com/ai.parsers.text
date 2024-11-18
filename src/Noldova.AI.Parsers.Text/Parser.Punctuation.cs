namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsPunctuation
            => char.IsPunctuation(context.CurrentCharacter);

        private void ParsePunctuations()
        {
            while(IsPunctuation)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}