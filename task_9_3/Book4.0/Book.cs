using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book4._0
{
    internal class Book : Item
    {
        #region Fields
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private static double price = 9;
        private bool returnedDate;
        #endregion

        #region Constructor 
        public Book()
        {
            price = 10;
        }

        public Book(string author, string title, int pages, int year)
            : this(author, title, null, pages, year) { }

        public Book(string author, string title, string? publisher, int pages, int year)
            : this(author, title, null, pages, year, 0, true) { }

        public Book(string author, string title, string? publisher, int pages, int year, long inventoryNumber, bool taken) : base(inventoryNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        #endregion

        #region Method
        public int CompareTo(object? obj)
        {
            Book comparedBook = (Book)obj;
            if (this.year == comparedBook.year) return 0;
            else if (this.year > comparedBook.year) return 1;
            else return -1;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public double PriceBook(int s)
        {
            return s * price;
        }

        public void ReturnDate()
        {
            returnedDate = true;
        }

        public override void Return()
        {
            taken = returnedDate;
        }

        public override string ToString()
        {
            return $"\nBook:\nAuthor: {author}\nTitle: {title}\nPublished: {year}\n{pages} pages.\nRent price: {price}" + base.ToString();
        }
        #endregion
    }
}
