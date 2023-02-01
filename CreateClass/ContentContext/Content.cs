namespace Exercise.ContentContext
{
  public abstract class Content // faco com que eu nao permito implementar essa classe 
  {  // new content() -> nao vai funcionar pois e abstrata
    public Content() {
      id = Guid.NewGuid();
    }
    public Guid id { get; set; }

    public string title { get; set; }

    public string url { get; set; }
  }
}