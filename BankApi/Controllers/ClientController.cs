using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {
        var client = request.CreateClient(_nextId++);
        _clients.Add(client);

        return StatusCode(201, client);
    }

}