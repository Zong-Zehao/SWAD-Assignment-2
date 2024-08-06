using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    public int Id { get; set; }
    public List<AvailabilitySchedule> AvailabilitySchedules { get; set; }
    public List<RentalRate> RentalRates { get; set; }
    public List<Booking> Bookings { get; set; }

    //zehao's part start
    public string Make { get; set; }
    public int Year { get; set; }
    public int CarId { get; set; }

    // Navigation property
    public List<DamageReport> DamageReports { get; set; }
    public List<Insurance> Insurances { get; set; }
    // zehao's part end

    public Car()
    {
        AvailabilitySchedules = new List<AvailabilitySchedule>();
        RentalRates = new List<RentalRate>();
        Bookings = new List<Booking>();
    }

    public AvailabilitySchedule GetCurrentSchedule()
    {
        return AvailabilitySchedules.LastOrDefault();
    }

    public RentalRate GetCurrentRate()
    {
        return RentalRates.LastOrDefault();
    }

    public void SetNewSchedule(AvailabilitySchedule newSchedule)
    {
        AvailabilitySchedules.Add(newSchedule);
        Console.WriteLine("System validates and records the updated availability schedule.");
    }

    public void SetNewRate(RentalRate newRate)
    {
        RentalRates.Add(newRate);
        Console.WriteLine("System validates and records the updated rental rate.");
    }
}