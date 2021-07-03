using System;

namespace Project {
    class Book {
        public string title = "default";
        public int pages;
        private string author;

        /* STATIC VARIABLE */
        public static int bookCount = 0;


        public Book() {}

        public Book(string name, string aauthor) {
            Console.WriteLine("Creating Book\n");
            Author = aauthor;
            title = name;
            bookCount++;
        }
        public bool HasHonors() {
            return true;
        }

        public virtual void ReadBook() {
            Console.WriteLine("Reading a book\n");
        }

        /* GETTER AND SETTER */
        public string Author {
            get { return author; }
            set { author = value; }
        }

        public int getBookCount() {
            return bookCount;
        }
    }

    /* INHERITANCE */
    class AnotherBookClass : Book {
        public string cover;
        public override void ReadBook() {
            Console.WriteLine("Reading an another book\n");
        }
    }

    static class UsefulTools {
        /* STATIC METHOD */
        public static void SayHi(string name) {
            Console.WriteLine("Hello "+name);
        }
    }

    class Program {
        static void Main(string[] args) {
            Book book1 = new Book("Harry Potter", "JK Rowling");
            book1.pages = 500;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.Author);
            Console.WriteLine(book1.HasHonors());

            Console.WriteLine(Book.bookCount);

            Book book2 = new Book("Lord Of The Rings", "Tolkien");
            Console.WriteLine(book2.title);

            Console.WriteLine(Book.bookCount);
            Console.WriteLine(book1.getBookCount());

            UsefulTools.SayHi("John");
            //UsefulTools tools = new UsefulTools(); can't do that bc it's static class

            AnotherBookClass book3 = new AnotherBookClass();
            Console.WriteLine(book3.title);

            book2.ReadBook();
            book3.ReadBook();
        }
    }
}
