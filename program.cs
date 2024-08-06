using System;

class Program
{
    static void Main()
    {
        //Garence
        CarOwner carOwner = GetLoggedInCarOwner();
        Car car = GetCarForOwner(carOwner);

        // setting a new rate
        double newRate = 60.0;
        carOwner.SetNewRate(car, newRate);

        // Invalid rate example
        newRate = -10.0;
        carOwner.SetNewRate(car, newRate);

        // setting a new schedule
        DateTime newStartDateTime = DateTime.Now.AddDays(2);
        DateTime newEndDateTime = DateTime.Now.AddDays(3);
        carOwner.SetNewSchedule(car, newStartDateTime, newEndDateTime);

        // Invalid date example
        newStartDateTime = DateTime.Now.AddDays(-2);
        newEndDateTime = DateTime.Now.AddDays(1); 
        carOwner.SetNewSchedule(car, newStartDateTime, newEndDateTime);


        // Izwan
        // Create Renter, which also serves as a User
        Renter renter = new Renter("D1234567", Renter.RenterType.Prime, 1, "Jane Smith", 987654321, new DateTime(1985, 10, 15))
        {
            // You can also set additional properties if needed
            DriversLicenseNo = "D1234567",
            RenterType = Renter.RenterType.Prime,
            BookList = new List<Booking>() // Initialize the list of bookings
        };

        // Add some bookings to the renter
        renter.BookList.Add(booking);

        // Display renter information
        Console.WriteLine(renter.ToString());
        Console.WriteLine("Bookings:");
        foreach (var booking in renter.BookList)
        {
            Console.WriteLine($"- {booking}");
        }
    }
}



