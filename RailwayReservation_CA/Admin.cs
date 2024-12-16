using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Admin
    {
        public string Name { get; set; }

        public Admin(string name)
        {
            Name = name;
        }

        public void AddTrain(List<Train> trains, string trainName, string source, string destination, int availableSeats)
        {
            Train newTrain = new Train(trainName, source, destination, availableSeats);
            trains.Add(newTrain);
            Console.WriteLine($"New train {trainName} added from {source} to {destination}.");
        }

        public void ViewAllBookings(List<Ticket> allTickets)
        {
            Console.WriteLine("All Bookings:");
            foreach (var ticket in allTickets)
            {
                ticket.DisplayTicketInfo();
            }
        }

        public void ViewRevenue(List<Ticket> allTickets)
        {
            decimal totalRevenue = 0;
            foreach (var ticket in allTickets)
            {
                totalRevenue += ticket.Price;
            }
            Console.WriteLine($"Total Revenue: {totalRevenue:C}");
        }
    }
