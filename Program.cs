// See https://aka.ms/new-console-template for more information


using Blog.Data;
using Blog.Model;

namespace Blog {
    class Program {
        static void Main(string [] args){
            Console.WriteLine("Hello, World!");

            using(var context = new DataContext()){
                var tag = new Tag{name = "Asp.Net", slug = "aspnet" };
                context.Tags.Add(tag);
                context.SaveChanges();

                // // LIST ALL TAGS
                // var test = context.Tags.First();

                // // update tag
                // tag = context.Tags.FirstOrDefault( item => item.id == 1);
                // tag.name = ".Net";
                // tag.slug = "dotnet";

            }
            
        }
    }
}