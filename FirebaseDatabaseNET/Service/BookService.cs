using Firebase.Database;
using FirebaseDatabaseNET.Models;
using System.Threading.Tasks;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;

namespace FirebaseDatabaseNET.Service
{
    internal class BookService
    {
        private const string firebaseDatabaseUrl = "https://talhafyp-default-rtdb.firebaseio.com/";
        private readonly FirebaseClient firebaseClient;

        public BookService()
        {
            firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
        }

        public async Task AddBook(BookModel book)
        {
            await firebaseClient
              .Child("Books")
              .PostAsync(book);
        }

        public async Task<List<KeyValuePair<string, BookModel>>> GetBooks()
        {
            var books = await firebaseClient
              .Child("Books")
              .OnceAsync<BookModel>();

            return books?
              .Select(x => new KeyValuePair<string, BookModel>(x.Key, x.Object))
              .ToList();
        }

        public async Task UpdateBook(string id, BookModel book)
        {
            await firebaseClient
             .Child("Books")
             .Child(id)
             .PutAsync(book);
        }

        public async Task RemoveBook(string id)
        {
            await firebaseClient
             .Child("Books")
             .Child(id)
             .DeleteAsync();
        }



    }
}
