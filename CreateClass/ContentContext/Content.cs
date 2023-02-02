namespace Exercise.ContentContext
{
  public abstract class Content // faco com que eu nao permito implementar essa classe 
  {  // new content() -> nao vai funcionar pois e abstrata
    public Content(string title, string url) {
      
      Title = title;
      Url = url;
      
    }
    public Guid id { get; set; }

    public string Title { get; set; }

    public string Url { get; set; }
  }
}