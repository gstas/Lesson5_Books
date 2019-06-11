using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Author james = new Author("Джеймс Кан");
            Author george = new Author("Джордж Лукас", DateTime.Parse("14.05.1944"));
            Author donald = new Author("Дональд Глут", DateTime.Parse("19.02.1944"), "USA");

            Console.WriteLine(james);
            Console.WriteLine(george);
            Console.WriteLine(donald);
            Console.WriteLine();

            Publisher alphabet = new Publisher("Азбука", "Россия");
            Publisher eksmo = new Publisher("Эксмо", "Россия", "www.eksmo.ru");
            Console.WriteLine(alphabet);
            Console.WriteLine(eksmo);
            Console.WriteLine();
        }
    }
}
