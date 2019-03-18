using HttpClientFactoryExamples.POCOs;
using System.Threading.Tasks;

namespace HttpClientFactoryExamples.Clients
{
    public interface ITodoClient
    {
        Task<ToDo> GetTodoAsync();
    }
}
