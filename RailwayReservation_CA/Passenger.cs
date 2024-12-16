using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
class Passenger
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public List<Ticket> BookingHistory { get; set; }
        public Passenger(string name, int age, string contact)
        {
            Name = name;
            Age = age;
            Contact = contact;
            BookingHistory = new List<Ticket>();
        }

    //Method to book a ticket

    public Ticket BookTicket(Train train, string seatType)
    {
        if (train.CheckAvailability())
        {
            Ticket newTicket = new Ticket(this, train, seatType);
            BookingHistory.Add(newTicket);
            train.UpdateAvailableSeats(seatType, -1); // Update available seats in the train
            Console.WriteLine($"Ticket booked for {train.TrainName} ({seatType}) - Price: {newTicket.Price:C}");
            return newTicket;
        }
        else
        {
            Console.WriteLine("No seats available on this train.");
            return null;
        }
    }

    // Method to view booking history

    public void ViewBookingHistory()
    {
        Console.WriteLine("Booking History:");
        foreach(var ticket in BookingHistory)
        {
            ticket.DisplayTicketInfo();
        }
    }


    // Method to cancel a ticket

    public void CancelTicket(Ticket ticket)
    {
        if (BookingHistory.Contains(ticket))
        {
            BookingHistory.Remove(ticket);
            ticket.CancelTicket();
        }
        else
        {
            Console.WriteLine("Ticket not found in booking history.");
        }
    }

}

