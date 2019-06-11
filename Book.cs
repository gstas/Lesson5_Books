using System;

namespace Lesson5_Books
{
    class Book
    {
        // Книга (5-6 основных полей, свойства (сеттеры и геттеры для каждого поля), несколько видов конструкторов, переопределить метод ToString())
        // В классе книга в качестве типов полей для автора и издательства использовать созданные классы

        string name, lang;
        ushort year, pages;

        Author[] authors;
        Publisher publisher;

        public string Name { get => name; set => name = value.Trim(); }
        public ushort Year
        {
            get => year;
            set => year = (value > (ushort)DateTime.Now.Year) ? (ushort)DateTime.Now.Year : value;
        }
        public ushort Pages { get => pages; set => pages = value; }
        public string Lang { get => lang; set => lang = value.Trim(); }
        internal Author[] Authors { get => authors; set => authors = value; }
        internal Publisher Publisher { get => publisher; set => publisher = value; }

        public Book(string name, Author[] authors, ushort pages, string lang)
        {
            Name = name;
            Authors = authors;
            Pages = pages;
            Lang = lang;
        }

        public Book(string name, Author[] authors, ushort pages, string lang, ushort year, Publisher publisher) : this(name, authors, pages, lang)
        {
            Year = year;
            Publisher = publisher;
        }

        public override string ToString()
        {
            string a = "", result = $"Книга: {Name}, Кол-во страниц: {Pages}, Язык: {Lang}\nАвтор(ы): ";
            foreach (var author in Authors)
            {
                a += (a == "") ? author.Name : ", " + author.Name;
            }
            result += a;

            result += (Year != 0) ? $"\nГод издания: {Year}" : "";
            result += (Publisher != null) ? $"\nИздательство: {Publisher.Name}" : "";

            return result;
        }

    }
}
