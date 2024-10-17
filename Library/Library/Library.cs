using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    internal class Library
    {
        public Book[] Books { get; set; }
        public int _index;


        public Library(int size)
        {
            Books = new Book[size];
            _index = 0;
        }


        public void AddBook(Book book)
        {
            if (_index < Books.Length)
            {
                Books[_index++] = book;
            }
            else
            {
                Console.WriteLine("Kitabxana doludu!");
            }
        }


        public Book[] GetFilteredBooks(string genre)
        {
            List<Book> filteredBooks = new List<Book>();

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null && Books[i].Genre == genre)
                {
                    filteredBooks.Add(Books[i]);
                }
            }
            return filteredBooks.ToArray();
        }


        public Book[] GetFilteredBooks(decimal minPrice, decimal maxPrice)
        {
            List<Book> filteredBooks = new List<Book>();


            for (int i = 0; i < Books.Length; i++)
            {

                if (Books[i] != null && Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    filteredBooks.Add(Books[i]);
                }
            }
            return filteredBooks.ToArray();
        }



        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                if (book != null)
                {
                    book.ShowInfo();
                }
            }
        }

    }
}
