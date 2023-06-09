using ICollection.Models;

namespace ICollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            // Membuat objek Author
            Author author1 = new Author
            {
                Id = 1,
                Name = "John Doe",
                Books = new List<Book>()
            };
            
            // Membuat objek Book
            Book book1 = new Book
            {
                Id = 1,
                Title = "Sample Book 1",
                Authors = new List<Author> { author1 }
            };

            // Menambahkan buku ke koleksi Books pada setiap penulis
            author1.Books.Add(book1);

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
            
            */
            Owner ownerTest = new Owner();

            Console.WriteLine(ownerTest.OwnerId);
            Owner owner1 = new Owner
            {
                OwnerId = 1,
                Name = "Widyan Irwadi",
                Vehicles = new List<Vehicle>()
            };

            Vehicle vehicle1 = new Vehicle
            {
                VehicleId = 1,
                Name = "Supra X",
                Description = "Supra X 125cc"
            };

            Vehicle vehicle2 = new Vehicle
            {
                VehicleId = 2,
                Name = "Kijang Innova",
                Description = "Kijang Innova 5000cc"
            };

            owner1.Vehicles.Add(vehicle1);
            owner1.Vehicles.Add(vehicle2);

            foreach(var vehicle in owner1.Vehicles)
            {
                Console.WriteLine(vehicle.Name + " " + vehicle.Description);
            }
        }
    }
}