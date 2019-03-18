using HttpClientFactoryExamples.Clients;
using HttpClientFactoryExamples.POCOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpClientFactoryExamples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITodoClient _todoClient;

        public ValuesController(ITodoClient githubClient)
        {
            _todoClient = githubClient;
        }
 
        [HttpGet]
        public async Task<ActionResult<ToDo>> Get()
        {
            return await _todoClient.GetTodoAsync();
        }
    }
}
