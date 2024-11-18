namespace Noldova.AI.Parsers.Text
{
    internal class ParserContext(string text)
    {
        public readonly char END_OF_TEXT = '\0';

        public readonly string Text = text;

        public HashSet<string> Names = [];

        public int StartIndex;

        public int CurrentIndex;

        public char CurrentCharacter
            => CurrentIndex < Text.Length ? Text[CurrentIndex] : END_OF_TEXT;

        public string CurrentValue
            => Text[StartIndex..CurrentIndex];

        public void AdjustIndexes()
            => StartIndex = CurrentIndex;

        public void Reset()
        {
            StartIndex = 0;
            CurrentIndex = 0;
            Names.Clear();
        }

        public void MoveNext()
            => CurrentIndex = CurrentCharacter != END_OF_TEXT && CurrentIndex < Text.Length
            ? CurrentIndex + 1
            : CurrentIndex;

        public void AddCurrentName()
            => Names.Add(CurrentValue);
    }
}