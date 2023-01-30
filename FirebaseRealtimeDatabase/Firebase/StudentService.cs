using FirebaseRealtimeDatabase.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseRealtimeDatabase.Firebase
{
    /*
     * for bypassing the auth, we sat the rules in firebase
     * {
          "rules": {
            ".read": "auth == null",
            ".write": "auth == null"
          }
        }
     */
    internal static class StudentService
    {
        internal static string firebaseDatabaseUrl = "https://talhafyp-default-rtdb.firebaseio.com/";
        internal static string firebaseDatabaseDocument = "Students";
        private static readonly HttpClient httpClient = new HttpClient();

        internal static async Task<StudentModel> Add(StudentModel model)
        {
            model.Id = Guid.NewGuid().ToString("N");
            string studentJsonString = JsonConvert.SerializeObject(model);

            var payload = new StringContent(studentJsonString, Encoding.UTF8, "application/json");

            string url = $"{firebaseDatabaseUrl}" + $"{firebaseDatabaseDocument}/" + $"{model.Id}.json";


            var httpResponseMessage = await httpClient.PutAsync(url, payload);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<StudentModel>(contentStream);
                return result;
            }

            return null;
        }

    }
}
