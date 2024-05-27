using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicketApp.Domain.Modals;

public class Ticket
{
    public string Id { get; set; }
    public string OwnerNameSurname { get; set; }
    public string SeatCode { get; set; }
    public decimal Price { get; set; }
}
