using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Customers")]
public class CustomerController : ControllerBase
{
    private static List<Customer> _customers = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult Get()
    {
        
        return StatusCode(200, _customers);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var Customer = _customers.FirstOrDefault(Customer => Customer.Id == id);

        if (Customer == null)
        {
            return NotFound("Customer not found");
        }
        return StatusCode(200, Customer);
    }

    [HttpPost]
    public ActionResult Create(CustomerRequest request)
    {
        var customer = request.CreateCustomer(_nextId++);
        _customers.Add(customer);

        return StatusCode(201, customer);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, CustomerRequest request)
    {
        var customer = _customers.FirstOrDefault(customer => customer.Id == id);

        if (customer == null)
        {
            return NotFound("Customer not found");
        }

        var customerUpdated = request.UpdateCustomer(customer);

        return Ok(customerUpdated);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var removed = _customers.RemoveAll(customer => customer.Id == id);

        if (removed == 0)
        {
            return NotFound("Customer not found");
        }
        
        return NoContent();
    }
}