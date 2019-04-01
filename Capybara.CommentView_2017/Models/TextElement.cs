namespace Capybara.CommentView_2017.Models
{
    public class TextElement : ISegmentElement
    {
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
