// See https://aka.ms/new-console-template for more information


using Blog.Data;
using Blog.Model;

namespace Blog {
    class Program {
        static void Main(string [] args){
            Console.WriteLine("Hello, World!");

             using(var context = new DataContext()){
                // var tag = new Tag{name = "node", slug = "Nodejs" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

             

                // // update tag
                //var tag = context.Tags.FirstOrDefault( item => item.id == 1);
                // tag.name = ".Net";
                // tag.slug = "dotnet";


                //remove or delete
                // context.Remove(tag);
                // context.SaveChanges();

                // to list 
                var tags = context.Tags.ToList();
                foreach( var tag in tags){
                    Console.WriteLine(tag.name);
                    Console.WriteLine(tag.slug);
                }

            }
            
        }
    }
}