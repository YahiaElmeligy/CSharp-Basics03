namespace CSharp_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Answer Question 1

            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }



            // Answer Question 2

            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

           

            // Answer Question 3

            int bookPages = 464;
            string sizeLabel = bookPages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);



            // Answer Question 4

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }



            // Answer Question 5

            int wIndex = 0;
            while (wIndex < books.Length)
            {
                Console.WriteLine(books[wIndex]);
                wIndex++;
            }



            // Answer Question 6

            int count = 1;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count <= 3);



            // Answer Question 7

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }



            // Answer Question 8

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }

        }
    }
}
