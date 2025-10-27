namespace Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime? OrderFulfilled { get; set; }
    public int CustomerId { get; set; }
    // nav property - 1 to 1 - 1 order has 1 customer
    public Customer Customer { get; set; }
    // nav property - intersection table ProductOrders
    public ICollection<ProductOrder> ProductOrders { get; set; }
}