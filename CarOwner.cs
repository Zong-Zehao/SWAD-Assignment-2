using System;

public class CarOwner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RegisteredCar { get; set; }

    public void NavigateToManageBookings()
    {
        DisplayBookings(Registeredcar);
    }

    private void DisplayBookings(Car car)
    {
        Console.WriteLine("Current Rental Rates:");
        foreach (var rate in car.RentalRates)
        {
            Console.WriteLine($"Rate: {rate.GetRate()}");
        }

        Console.WriteLine("Current Schedules:");
        foreach (var schedule in car.GetSchedules())
        {
            Console.WriteLine($"Start: {schedule.StartDateTime}, End: {schedule.EndDateTime}");
        }
    }

    public void SetNewRate(Car car, double newRate)
    {
        try
        {
            RentalRate rentalRate = new RentalRate(newRate);
            car.UpdateRate(rentalRate);
            Console.WriteLine("Updated Rate: " + newRate);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void SetNewSchedule(Car car, DateTime newStartDateTime, DateTime newEndDateTime)
    {
        try
        {
            AvailabilitySchedule schedule = new AvailabilitySchedule(newStartDateTime, newEndDateTime);
            car.UpdateSchedule(schedule);
            Console.WriteLine($"Updated Schedule from {newStartDateTime} to {newEndDateTime}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}





