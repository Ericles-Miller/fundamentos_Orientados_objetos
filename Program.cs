// See https://aka.ms/new-console-template for more information


using Blog.Data;

namespace Blog {
    class Program {
        static void Main(string [] args){
            Console.WriteLine("Hello, World!");

            using(var context = new DataContext()){
                
            }
            
        }
    }
}