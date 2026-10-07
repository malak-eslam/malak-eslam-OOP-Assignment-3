namespace part_01.src.Orders;

public class OrderProcessor
{
    private readonly IOrderRepository _repo;
    private readonly IEmailSender _email;

    public OrderProcessor(IOrderRepository orderRepository, IEmailSender emailSender)
    {
        _repo = orderRepository;
        _email = emailSender;
    }

    public void Process(int orderId, string customerEmail)
    {
 
        _repo.Save(orderId, DateTime.Now);
        _email.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}



