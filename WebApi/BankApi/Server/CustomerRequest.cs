
public class CustomerRequest
{
    public string? Name {get;set;}
    public decimal AccountBalance {get;set;}
    
    public Customer CreateCustomer(int id)
    {
        return new Customer
        {
            Id = id,
            Name = Name,
            AccountBalance = AccountBalance,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }

    public Customer UpdateCustomer(Customer customer)
    {
        customer.Name = Name;
        customer.AccountBalance = AccountBalance;
        customer.UpdatedAt = DateTime.Now;
        return customer;
    }
}