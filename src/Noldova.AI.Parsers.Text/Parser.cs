using System.Globalization;

namespace Noldova.AI.Parsers.Text
{
    public partial class Parser(string text)
    {
        private readonly ParserContext context = new(text);

        public string[] Parse()
        {
            context.Reset();

            while(!IsEndOfText)
                ParseInternal();

            return CreateNames();
        }

        private void ParseInternal()
        {
            context.AdjustIndexes();

            if(IsLetter)
                ParseLetters();
            else if(IsWhiteSpace)
                ParseWhiteSpaces();
            else if(IsLineBreak)
                ParseLineBreaks();
            else if(IsDigit)
                ParseDigits();
            else if(IsPunctuation)
                ParsePunctuations();
            else if(IsEndOfText)
                ParseEndOfText();
            else
                ParseOthers(); 
        }

        private string[] CreateNames()
        {
            var uniqueCharacters = new HashSet<char>(string.Concat(context.Names));
            var textElementEnumerator = StringInfo.GetTextElementEnumerator(string.Concat(uniqueCharacters));

            while(textElementEnumerator.MoveNext())
                context.Names.Add(textElementEnumerator.GetTextElement());

            return [.. context.Names.Order()];
        }
    }
}