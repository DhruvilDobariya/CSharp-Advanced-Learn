using DisplayCollection;
using System.Net;
using System.Text.Json;

namespace HttpWebRequestLearn
{
    public class Program
    {
        private static readonly string _baseURL = "https://jsonplaceholder.typicode.com/";

        public static void Main(string[] args)
        {
            GetToDos();
        }
        public static void GetToDos()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_baseURL + "todos");
            // OR
            //HttpWebRequest request = WebRequest.CreateHttp(_baseURL + "todos");

            request.Method = "GET";
            request.Headers.Add("Accept", "application/json");
            request.Headers["Content-Type"] = "application/json";
            //request.Headers.Remove("Accept");

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                Console.WriteLine(response.StatusCode);
                List<Todo> todos = JsonSerializer.Deserialize<List<Todo>>(reader.ReadToEnd());
                Display.Table(todos);
            }
        }
    }
}
