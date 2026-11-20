using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Orders;
public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}