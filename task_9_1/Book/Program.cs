using System.Security.Cryptography;
using System.Xml.Linq;

namespace Book
{
    internal class Book : IComparable
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private static double price = 9;
        public Book()
        {
            price = 10;
        }

        public Book(string author, string title, int pages, int year)
            : this(author, title, null, pages, year) { }

        public Book(string author, string title, string? publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public int CompareTo(object? obj)
        {
            Book comparedBook = (Book)obj;
            if (this.year == comparedBook.year) return 0;
            else if (this.year > comparedBook.year) return 1;
            else return -1;
        }

        public override string ToString()
        {
            return $"\nBook:\nAuthor: {author}\nTitle: {title}\nPublished: {year}\n{pages} pages.\nRent price: {price}";
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public double PriceBook(int s)
        {
            return s * price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
                new("Harper Lee", "To Kill a Mockingbird", 281, 1960),
                new("F. Scott Fitzgerald", "The Great Gatsby", 208, 1925)
            };
            Book.SetPrice(12.00);
            Array.Sort(books);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}