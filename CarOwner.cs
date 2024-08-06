using System;

public class CarOwner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RegisteredCar { get; set; }

    public void NavigateToManageBookings()
    {
        Console.WriteLine($"{Name} navigates to manage bookings.");
    }

    public void ModifyRentalRate(Car car, double newRate)
    {
        RentalRate rentalRate = new RentalRate();
        rentalRate.SetRate(newRate);
        if (rentalRate.IsValidRate(newRate))
        {
            car.SetNewRate(rentalRate);
            Console.WriteLine("Updated rental rate confirmed.");
        }
    }

    public void ModifyAvailabilitySchedule(Car car, DateTime newSchedule)
    {
        AvailabilitySchedule availabilitySchedule = new AvailabilitySchedule();
        availabilitySchedule.SetDate(newSchedule);
        if (availabilitySchedule.IsValidDate(newSchedule))
        {
            car.SetNewSchedule(availabilitySchedule);
            Console.WriteLine("Updated availability schedule confirmed.");
        }
    }
}





