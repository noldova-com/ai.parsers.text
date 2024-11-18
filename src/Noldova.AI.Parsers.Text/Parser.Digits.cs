namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsDigit
            => char.IsDigit(context.CurrentCharacter);

        private void ParseDigits()
        {
            while(IsDigit)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}