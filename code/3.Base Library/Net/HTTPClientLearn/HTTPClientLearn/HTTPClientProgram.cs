using DisplayCollection;
using Newtonsoft.Json;


namespace HTTPClientDemo
{
    public class HTTPClientProgram
    {
        public static void Main(string[] args)
        {
             GetToDos();
            // GetByIdToDo(21);
            // AddToDo();
            // UpdateToDo();
            // DeleteDoTo(1);
        }
        public static void GetToDos()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            HttpResponseMessage responce = httpClient.GetAsync("todos").Result;
            if (responce.IsSuccessStatusCode)
            {
                string todos = responce.Content.ReadAsStringAsync().Result.ToString();
                //Console.WriteLine(todo);
                List<Todo> todos1 = JsonConvert.DeserializeObject<List<Todo>>(todos.ToString());
                Display.Table(todos1);
                
            }
            else
            {
                Console.WriteLine(responce.StatusCode + " " + responce.ReasonPhrase);
            }
        }
        public static void GetByIdToDo(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            HttpResponseMessage responce = httpClient.GetAsync($"todos/{id}").Result;
            if (responce.IsSuccessStatusCode)
            {
                string todo = responce.Content.ReadAsStringAsync().Result.ToString();
                //Console.WriteLine(todo);
                Todo todo1 = JsonConvert.DeserializeObject<Todo>(todo.ToString());
                Display.DisplayObject(todo1);
            }
            else
            {
                Console.WriteLine(responce.StatusCode + " " + responce.ReasonPhrase);
            }
        }
        public static void AddToDo()
        {
            using(HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                httpClient.DefaultRequestHeaders.Add("Accept", "text/plain");
                httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Remove("Accept");

                StringContent stringContent = new StringContent(JsonConvert.SerializeObject(new Todo() { userId = 1, title = "AddDataTitle", completed = true }));

                HttpResponseMessage responce = httpClient.PostAsync("todos", stringContent).Result;
                if (responce.IsSuccessStatusCode)
                {
                    string todo = responce.Content.ReadAsStringAsync().Result.ToString();
                    Console.WriteLine(todo);
                }
                else
                {
                    Console.WriteLine(responce.StatusCode + " " + responce.ReasonPhrase);
                }
            }
        }
        public static void UpdateToDo()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(new Todo() { userId = 1, id = 1, title = "UpdateDataTitle", completed = true }));

            HttpResponseMessage responce = httpClient.PutAsync("todos", stringContent).Result;
            if (responce.IsSuccessStatusCode)
            {
                string todo = responce.Content.ReadAsStringAsync().Result.ToString();
                Console.WriteLine(todo);
            }
            else
            {
                Console.WriteLine(responce.StatusCode + " " + responce.ReasonPhrase);
            }
        }
        public static void DeleteDoTo(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

            HttpResponseMessage responce = httpClient.GetAsync($"todos/{id}").Result;
            if (responce.IsSuccessStatusCode)
            {
                string todo = responce.Content.ReadAsStringAsync().Result.ToString();
                Console.WriteLine(todo);
            }
            else
            {
                Console.WriteLine(responce.StatusCode + " " + responce.ReasonPhrase);
            }
        }
    }
}


