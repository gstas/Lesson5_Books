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
            Console.WriteLine(alphabet);
            Console.WriteLine();

            Book starWars = new Book("Star Wars", new Author[] {james, george, donald}, 500, "рус");
            Console.WriteLine(starWars);
            Console.WriteLine();


            Author joseph = new Author("Джозеф Албахари");
            Author ben = new Author("Бен Албахари", DateTime.Parse("25.11.1976"));
            Console.WriteLine(joseph);
            Console.WriteLine(ben);
            Console.WriteLine();

            Publisher oreilly = new Publisher("O'Reilly", "USA", "www.oreilly.com", "1005 Gravenstein Highway NorthSebastopol, CA 95472 USA");
            Console.WriteLine(oreilly);
            Console.WriteLine();

            Book cSharp = new Book("C# для чайников", new Author[] { joseph, ben }, 712, "eng", 2017, oreilly);
            Console.WriteLine(cSharp);
            Console.WriteLine();

        }
    }
}
