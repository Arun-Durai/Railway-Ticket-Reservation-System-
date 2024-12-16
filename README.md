# Railway Ticket Reservation System

## Description
This system simulates a railway ticket booking and management platform. Passengers can book tickets, view their booking history, and cancel tickets. An admin can manage trains, view all bookings, and check the total revenue.

## Features

### Passenger Functionality:
- **Book Ticket:** Allows passengers to book tickets for available trains by choosing a seat type (Sleeper, First Class, or AC).
- **View Booking History:** Displays all previous bookings for a passenger.
- **Cancel Ticket:** Allows passengers to cancel previously booked tickets.

### Admin Functionality:
- **Add Train:** Admin can add new trains to the system.
- **View All Bookings:** Admin can view the list of all booked tickets in the system.
- **View Revenue:** Admin can view the total revenue generated from all bookings.

## How to Use

### Starting the System:
The system starts by displaying a menu with several options:
- **Search Trains**
- **Book Ticket**
- **View Booking History**
- **Cancel Ticket**
- **Admin Login**
- **Exit**

### Passenger Operations:
- **Search Trains:** Displays a list of available trains with their details.
- **Book Ticket:** The passenger enters the train name, selects a seat type, and the ticket is booked if there are available seats.
- **View Booking History:** The passenger can view their previous bookings with details.
- **Cancel Ticket:** The passenger enters a ticket ID to cancel a booked ticket.

### Admin Operations:
- **Add Train:** Admin can add a new train by providing its name, source, destination, and available seats.
- **View All Bookings:** Admin can view all the bookings made by passengers.
- **View Revenue:** Admin can check the total revenue generated from ticket bookings.

## Code Structure
- **Program.cs:** Contains the main program flow and the interactive console interface where the user can perform various operations.
- **Train.cs:** Defines the `Train` class, which includes methods for displaying train details, updating seat availability, and checking availability.
- **Passenger.cs:** Defines the `Passenger` class, which includes methods for booking tickets, viewing booking history, and canceling tickets.
- **Ticket.cs:** Defines the `Ticket` class, which includes methods for displaying ticket details and calculating ticket prices.
- **Admin.cs:** Defines the `Admin` class, which includes methods for adding new trains, viewing all bookings, and calculating total revenue.

## Sample Output
```yaml
--- Railway Ticket Reservation System ---
1. Search Trains
2. Book Ticket
3. View Booking History
4. Cancel Ticket
5. Admin Login
6. Exit
Enter your choice: 1

--- Train List ---
Train: Train 101, From: New York, To: Chicago, Available Seats: 100
Train: Train 102, From: Los Angeles, To: San Francisco, Available Seats: 50
