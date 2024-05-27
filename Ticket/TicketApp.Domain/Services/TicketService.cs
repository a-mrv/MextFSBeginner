using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Domain.Modals;

namespace TicketApp.Domain.Services
{
    public class TicketService
    {
        public void SaveTicketToTextFile(string ownerNameSurname, string seatCode, decimal price )
        {
            Random random = new();
            Ticket ticket = new()
            {
                Id=$"{random.Next(1,1000)}",
                OwnerNameSurname = ownerNameSurname,
                SeatCode = seatCode,
                Price = price
            };


            string ticketInfo = $"{ticket.Id},{ticket.OwnerNameSurname},{ticket.SeatCode},{ticket.Price}\n";

            File.AppendAllText("C:\\Users\\MERVE\\source\\repos\\Ticket\\TicketApp.Domain\\ticket.txt", ticketInfo);

        }


    }
}
