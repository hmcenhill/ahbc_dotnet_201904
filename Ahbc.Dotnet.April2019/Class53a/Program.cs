using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Class53a
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44397");

            // Serializing takes an object and converts it to a text format, like json
            var body = JsonConvert.SerializeObject(
                new Employee
                {
                    Name = new Name
                    {
                        FirstName = "Jason",
                        LastName = "Robert"
                    },
                    Nickname = "Grown man"
                });

            var postContent = new StringContent(body);
            
            // Headers provide metadata about the request such as, the type of data we are sending
            if (postContent.Headers.Contains("Content-Type"))
                postContent.Headers.Remove("Content-Type");
            postContent.Headers.Add("Content-Type", "application/json");

            // HttpClient is used to send our requests to the server
            var postResponse = await client.PostAsync("api/employees", postContent);
            var response = await client.GetAsync("api/employees");
            var content = await response.Content.ReadAsStringAsync();

            // Deserialization is the process of taking a text format and converting it to .NET Objects
            var employees = JsonConvert.DeserializeObject<Employee[]>(content);

            Console.WriteLine(content);
        }
    }
}
