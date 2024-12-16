using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ticket
    {
        public Passenger Passenger { get; set; }
        public Train Train { get; set; }
        public string SeatType { get; set; }
        public decimal Price { get; set; }
        public string TicketID { get; set; }

        public Ticket(Passenger passenger, Train train, string seatType)
        {
            Passenger = passenger;
            Train = train;
            SeatType = seatType;
            TicketID = Guid.NewGuid().ToString();
        }

        public void DisplayTicketInfo()
        {
            Console.WriteLine($"Ticket ID: {TicketID}, Passenger: {Passenger.Name}, Train: {Train.TrainName}, Seat: {SeatType}, Price: {Price:C}");
        }

        public void CancelTicket()
        {
            Console.WriteLine("Ticket Cancelled");
        }

        public decimal CalculateTicketPrice(string seatType)
        {
            decimal basePrice = 100;
            if (seatType == "First Class") basePrice *= 1.5m;
            else if (seatType == "AC") basePrice *= 1.2m;
            return basePrice;
        }
    }
