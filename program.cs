using System;

class Program
{
    static void Main()
    {
        CarOwner carOwner = new CarOwner { Id = 1, Name = "John", RegisteredCar = "ABC123" };
        carOwner.NavigateToManageBookings();

        Car car = new Car { Id = 1 };
        RentalRate rentalRate = new RentalRate { Rate = 50.0 };
        AvailabilitySchedule availabilitySchedule = new AvailabilitySchedule { Date = DateTime.Now.AddDays(1) };

        // Example of setting a new rate
        double newRate = 60.0;
        carOwner.ModifyRentalRate(car, newRate);

        // Invalid rate example
        newRate = -10.0;
        carOwner.ModifyRentalRate(car, newRate);

        // Example of setting a new schedule
        DateTime newDate = DateTime.Now.AddDays(2); // Example future date
        carOwner.ModifyAvailabilitySchedule(car, newDate);

        // Invalid date example
        newDate = DateTime.Now.AddDays(-2); // Example past date
        carOwner.ModifyAvailabilitySchedule(car, newDate);

        // Create a new booking
        Booking booking = new Booking(1, DateTime.Now, new TimeSpan(10, 0, 0), DateTime.Now.AddDays(1), new TimeSpan(10, 0, 0), "Pickup at location", 100, carOwner, car);
        car.Bookings.Add(booking);

        Console.WriteLine(booking.ToString());
    }
}



