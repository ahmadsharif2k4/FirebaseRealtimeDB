using FirebaseDatabaseNET.Models;
using FirebaseDatabaseNET.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseDatabaseNET
{
    //using below nuget package for interacting with firebase realtime database
    //Install-Package FirebaseDatabase.net

    internal class Program
    {
        static async Task Main(string[] args)
        {
            BookService service = new BookService();

            BookModel book = new BookModel()
            {
                Name = "Ahmad Sharif",
                Description = "learning firebase realtime database",
                Price = "$25"
            };

            await service.Add(book);
            await service.GetBooks();
            Console.ReadLine();

        }
    }
}
