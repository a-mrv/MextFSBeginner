// See https://aka.ms/new-console-template for more information
using TicketApp.Domain.Services;



TicketService ticketService = new();

ticketService.SaveTicketToTextFile("Merve Aydoğan","35A",100);

Console.WriteLine("Ticket saved to text file.");