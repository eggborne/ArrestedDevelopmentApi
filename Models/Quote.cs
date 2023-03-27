namespace ArrestedDevelopmentApi.Models
{
  public class Quote
  {
    public int QuoteId { get; set; }
    public string Speaker { get; set; }
    public string Text { get; set; }

    public int LengthInWords {
      get {
        return Text.Split(' ').Length;
      }
    }
  }
}