using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Books
{
    class Publisher
    {
        // Издательство (3-4 основных поля, свойства (сеттеры и геттеры для каждого поля), несколько видов конструкторов, переопределить метод ToString())
        string name, country, address, web;

        public string Name { get => name; set => name = value.Trim(); }
        public string Country { get => country; set => country = value.Trim(); }
        public string Address { get => address; set => address = value.Trim(); }
        public string Web { get => web; set => web = value.Trim(); }

        public Publisher(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public Publisher(string name, string country, string web): this(name, country)
        {
            
            Web = web;
        }

        public Publisher(string name, string country, string web, string address) : this(name, country, web)
        {
            Address = address;
        }

        public override string ToString()
        {
            string result = $"Издательство: {Name} ({Country})";
            result += (Web != "" && Web != null) ? $", Сайт: {Web}" : "";
            result += (Address != "" && Address != null) ? $", Адрес: {Address}" : "";

            return result;
        }
    }
}
