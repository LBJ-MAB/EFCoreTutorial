namespace Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    // 1 to many relationship. 1 customer -> many orders
    public ICollection<Order> Orders { get; set; }
}