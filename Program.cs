using System;
using System.Linq;

namespace RepositoryPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new TestCategoryRepository();
            var svc = new CategoryService(rep);

            var categories = svc.GetCategories();

            Console.WriteLine("Top level category count: " + categories.Count);
            Console.WriteLine("");
            
            Console.WriteLine("Total category count: " + categories.Flatten().Count());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
