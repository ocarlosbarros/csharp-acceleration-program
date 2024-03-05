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

}