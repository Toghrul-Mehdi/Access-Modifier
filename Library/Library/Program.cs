namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            
            Book book1 = new Book(1, "Harry Potter", 15.99m, "Fantastik");
            Book book2 = new Book(2, "Sefiller", 12.50m, "Epik");
            Book book3 = new Book(3, "Tixtix xanim", 25.00m, "Nagil");
            Book book4 =new Book(4, "Cirtdan", 10.00m, "Nagil");
            Book book5 = new Book(5, "Gorunmez Adam", 15.00m, "Fantastik");
            Book book6 = new Book(6, "Dede Qorqud", 30.00m, "Epik");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);


            Console.WriteLine("Butun Kitablar:");
            library.ShowAllBooks();

            Console.WriteLine("Janr daxil edin:");
            string janr=Console.ReadLine();

            Console.WriteLine(janr+" Kitablari:");
            library.GetFilteredBooks(janr);

            Console.WriteLine("Araliq(min) daxil edin:");

            int minprice;
            bool bool_minprice=int.TryParse(Console.ReadLine(), out minprice);

            Console.WriteLine("Araliq(max) daxil edin:");

            int maxprice;
            bool bool_maxprice = int.TryParse(Console.ReadLine(), out maxprice);

            Console.WriteLine("Daxil etdiyiniz araliqda kitablar:"+"("+minprice+","+maxprice+")");
            library.GetFilteredBooks(minprice,maxprice);
        }
    }
}
