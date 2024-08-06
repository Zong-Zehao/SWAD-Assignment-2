using System;

public class CarOwner
{
    //Garence
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
        car.UpdateRate(newRate);
    }

    public void SetNewSchedule(Car car, DateTime newStartDateTime, DateTime newEndDateTime)
    {
        car.UpdateSchedule(newStartDateTime, newEndDateTime);
    }
}





