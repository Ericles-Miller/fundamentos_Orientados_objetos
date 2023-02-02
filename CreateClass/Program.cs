using Exercise.ContentContext;

namespace MyApp
{
  class Program {
    static void Main(string[] args) {
      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre C#", "CSharp"));
      articles.Add(new Article("Artigo sobre dotNet", "dotnet"));

      foreach(var article in articles) {
        Console.WriteLine(article.id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      }
    }

  }
}
