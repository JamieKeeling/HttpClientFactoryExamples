using HttpClientFactoryExamples.POCOs;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactoryExamples.Clients
{
    public class TodoClient : ITodoClient
    {
        private readonly HttpClient _client;

        public TodoClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/1");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            _client = client;
        }

        public async Task<ToDo> GetTodoAsync()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get
            };

            var response = await _client.SendAsync(request);

            return await response.Content.ReadAsAsync<ToDo>();
        }
    }
}
