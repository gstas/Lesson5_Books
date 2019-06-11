using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Books
{
    class Author
    {
        // Автор (2-3 основных поля, свойства (сеттеры и геттеры для каждого поля), несколько видов конструкторов, переопределить метод ToString())
        string name;
        DateTime birthday;
        string country;

        public Author(string name)
        {
            Name = name;
        }

        public Author(string name, DateTime birthday) : this(name)
        {
            Birthday = birthday;
        }

        public Author(string name, DateTime birthday, string country) : this(name, birthday)
        {
            Country = country;
        }

        public string Name { get => name; set => name = value.Trim(); }
        public DateTime Birthday
        {
            get => birthday;
            set => birthday = birthday > DateTime.Now ? DateTime.Now : value;
        }
        public string Country { get => country; set => country = value.Trim(); }

        public override string ToString()
        {
            string result = $"Автор: {Name}";
            if (Birthday != null && Convert.ToString(Birthday) != "" && Birthday.Year != 1)
                result += $", родился: {Birthday.ToShortDateString()}";
            if (Country != null && Country != "")
                result += $", страна: { Country}";

            return result;
        }
    }
}
