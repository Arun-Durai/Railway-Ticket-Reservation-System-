
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Sample data for trains and passengers
        List<Train> trains = new List<Train>
        {
            new Train("Train 101", "New York", "Chicago", 100),
            new Train("Train 102", "Los Angeles", "San Francisco", 50)
        };

        List<Ticket> allTickets = new List<Ticket>();  // Stores all tickets booked in the system

        Admin admin = new Admin("John");
        Passenger passenger = new Passenger("Alice", 30, "123-456-7890");

        while (true)
        {
            Console.WriteLine("\n--- Railway Ticket Reservation System ---");
            Console.WriteLine("1. Search Trains");
            Console.WriteLine("2. Book Ticket");
            Console.WriteLine("3. View Booking History");
            Console.WriteLine("4. Cancel Ticket");
            Console.WriteLine("5. Admin Login");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Train List ---");
                    foreach (var train in trains)
                    {
                        train.DisplayTrainDetails();
                    }
                    break;

                case "2":
                    Console.WriteLine("\nEnter train name to book: ");
                    string trainName = Console.ReadLine();
                    Train selectedTrain = trains.Find(t => t.TrainName == trainName);
                    if (selectedTrain != null)
                    {
                        Console.WriteLine("Select seat type (Sleeper / First Class / AC): ");
                        string seatType = Console.ReadLine();
                        Ticket newTicket = passenger.BookTicket(selectedTrain, seatType);
                        if (newTicket != null)
                        {
                            allTickets.Add(newTicket);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Train not found.");
                    }
                    break;

                case "3":
                    passenger.ViewBookingHistory();
                    break;

                case "4":
                    Console.WriteLine("\nEnter Ticket ID to cancel: ");
                    string ticketID = Console.ReadLine();
                    Ticket ticketToCancel = allTickets.Find(t => t.TicketID == ticketID);
                    if (ticketToCancel != null)
                    {
                        passenger.CancelTicket(ticketToCancel);
                    }
                    else
                    {
                        Console.WriteLine("Ticket not found.");
                    }
                    break;

                case "5":
                    Console.WriteLine("\nAdmin Login: ");
                    Console.WriteLine("1. Add Train");
                    Console.WriteLine("2. View All Bookings");
                    Console.WriteLine("3. View Revenue");
                    string adminChoice = Console.ReadLine();
                    if (adminChoice == "1")
                    {
                        Console.WriteLine("Enter train details (name, source, destination, available seats): ");
                        string name = Console.ReadLine();
                        string source = Console.ReadLine();
                        string destination = Console.ReadLine();
                        int availableSeats = int.Parse(Console.ReadLine());
                        admin.AddTrain(trains, name, source, destination, availableSeats);
                    }
                    else if (adminChoice == "2")
                    {
                        admin.ViewAllBookings(allTickets);
                    }
                    else if (adminChoice == "3")
                    {
                        admin.ViewRevenue(allTickets);
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}

