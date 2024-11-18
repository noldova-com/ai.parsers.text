namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsLetter
            => char.IsLetter(context.CurrentCharacter);

        private void ParseLetters()
        {
            while(IsLetter)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}