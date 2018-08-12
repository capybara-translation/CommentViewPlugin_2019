namespace Capybara.CommentView.Models
{
    public class CommentElement : ISegmentElement
    {
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
