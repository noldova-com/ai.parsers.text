namespace Noldova.AI.Parsers.Text
{
    public partial class Parser
    {
        private bool IsLineBreak
            => context.CurrentCharacter switch
            {
                '\r' or '\n' or '\u0085' or '\u2028' or '\u2029' => true,
                _ => false,
            };

        private void ParseLineBreaks()
        {
            while(IsLineBreak)
                context.MoveNext();

            context.AddCurrentName();
        }
    }
}