using ICollection.Models;

namespace ICollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Author
            Author author1 = new Author
            {
                Id = 1,
                Name = "John Doe",
                Books = new List<Book>()
            };

            Author author2 = new Author
            {
                Id = 2,
                Name = "Jane Smith",
                Books = new List<Book>()
            };


            
            // Membuat objek Book
            Book book1 = new Book
            {
                Id = 1,
                Title = "Sample Book 1",
                Authors = new List<Author> { author1 }
            };

            var book2 = new Book
            {
                Id = 2,
                Title = "Sample Book 2",
                Authors = new List<Author> { author1, author2, author1 }
            };

            
            
            // Menambahkan buku ke koleksi Books pada setiap penulis
            author1.Books.Add(book1);
            author1.Books.Add(book2);
            author2.Books.Add(book2);

            // Menampilkan informasi penulis dan bukunya
            Console.WriteLine("Authors and their Books:");
            Console.WriteLine();

            Console.WriteLine($"Author: {author1.Name} (ID: {author1.Id})");
            Console.WriteLine("Books:");
            foreach (var book in author1.Books)
            {
                Console.WriteLine($"- {book.Title} (ID: {book.Id})");
            }
            Console.WriteLine();

            Console.WriteLine($"Author: {author2.Name} (ID: {author2.Id})");
            Console.WriteLine("Books:");
            foreach (var book in author2.Books)
            {
                Console.WriteLine($"- {book.Title} (ID: {book.Id})");
            }

            // Menghapus buku dari koleksi Books pada penulis
            author1.Books.Remove(book1);

            Console.WriteLine();
            Console.WriteLine("After removing a book from Author 1:");
            Console.WriteLine($"Author: {author1.Name} (ID: {author1.Id})");
            Console.WriteLine("Books:");
            foreach (var book in author1.Books)
            {
                Console.WriteLine($"- {book.Title} (ID: {book.Id})");
            }
            
        }
    }
}