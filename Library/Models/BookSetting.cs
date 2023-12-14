namespace Library.Models
{
    public class BookSetting
    {
        public int WordCountPerPage { get; private set; }
        public FontSize FontSize { get; private set; }

        public BookSetting(FontSize fontSize = FontSize.Medium)
        {
            FontSize = fontSize;
            CalculateNumbersOfCharacter();
        }

        public void ChangeFontSize(FontSize fontSize)
        {
            FontSize = fontSize;
            CalculateNumbersOfCharacter();
        }

        public void CalculateNumbersOfCharacter()
        {
            WordCountPerPage = FontSize switch
            {
                FontSize.Small => 12,
                FontSize.Medium => 10,
                FontSize.Big => 8,
                _ => throw new ArgumentOutOfRangeException($"Invalid input")
            };
        }
    }

    public enum FontSize
    {
        Small = 1,
        Medium,
        Big,
    }

}