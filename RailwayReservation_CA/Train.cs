using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Train
{
    public string TrainName { get; set; }
    public string Source { get; set; }
    public string Destination { get; set; }
    public int AvailableSeats { get; set; }
    public List<string> SeatTypes { get; set; }

    public Train(string trainName, string source, string destination, int availableSeats)
    {
        TrainName = trainName;
        Source = source;
        Destination = destination;
        AvailableSeats = availableSeats;
        SeatTypes = new List<string> { "Sleeper", "First Class", "AC" };
    }


    public void DisplayTrainDetails()
    {
        Console.WriteLine($"Train: {TrainName}, From: {Source}, To: {Destination}, Available Seats: {AvailableSeats}");
    }


    public void UpdateAvailableSeats(string seatType, int change)
    {
        AvailableSeats += change;
    }

    public bool CheckAvailability()
    {
        return AvailableSeats > 0;
    }
}
