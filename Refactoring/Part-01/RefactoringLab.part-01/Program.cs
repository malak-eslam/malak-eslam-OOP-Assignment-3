using part_01.src;


var aramex = new ShippingCostCalculator(new AramexCarrier());
Console.WriteLine($"Aramex 2kg → {aramex.Calculate(2)}");

var fedEx = new ShippingCostCalculator(new FedExCarrier());
Console.WriteLine($"FedEx 2kg → {fedEx.Calculate(2)}");

var ups = new ShippingCostCalculator(new UpsCarrier());
Console.WriteLine($"UPS 2kg → {ups.Calculate(2)}");

Console.WriteLine();



var processor = new OrderProcessor(new SqlOrderRepository() ,new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new ScheduledNotification(
    new UrgentNotification(
        new Notification(
            new EmailChannel())),
    DateTime.Today.AddHours(18))
    .Send("customer@example.com", "Your order ships tomorrow");

new UrgentNotification(
    new Notification(
        new SmsChannel()))
    .Send("+201000000000", "OTP 4821");


new UrgentNotification(
    new Notification(new WhatsAppChannel()))
    .Send("+201000000000", "Your order is ready");