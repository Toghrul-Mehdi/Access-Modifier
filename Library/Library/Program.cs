namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(3);

            
            Book book1 = new Book(1, "Harry Potter", 15.99m, "Fantastik");
            Book book2 = new Book(2, "Sefiller", 12.50m, "Epik");
            Book book3 = new Book(3, "Tixtix xanim", 25.00m, "Nagil");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            
            Console.WriteLine("Butun Kitablar:");
            library.ShowAllBooks();

            
            Console.WriteLine("Nagil Kitablari:");
            Book[] nagilkitablari = library.GetFilteredBooks("Nagil");
            foreach(Book book in nagilkitablari)
            {
                book.ShowInfo();
            }
            
            
            Console.WriteLine("15-30 manat arasi kitablar:");
            Book[] kitab_index = library.GetFilteredBooks(15, 30);
            foreach (var book in kitab_index)
            {
                book.ShowInfo();
            }


        }
    }
}
