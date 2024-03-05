using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult Get()
    {
        
        return StatusCode(200, _clients);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var client = _clients.FirstOrDefault(client => client.Id == id);

        if (client == null)
        {
            return NotFound("Client not found");
        }
        return StatusCode(200, client);
    }

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {
        var client = request.CreateClient(_nextId++);
        _clients.Add(client);

        return StatusCode(201, client);
    }

}