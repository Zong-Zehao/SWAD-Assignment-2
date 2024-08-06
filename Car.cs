using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    //Garence
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

    public AvailabilitySchedule Schedule
    {
        get { return AvailabilitySchedules.LastOrDefault(); }
        set { UpdateSchedule(value.StartDateTime, value.EndDateTime); }
    }

    public RentalRate CurrentRate
    {
        get { return RentalRates.LastOrDefault(); }
        set { UpdateRate(value.Rate); }
    }

    public List<AvailabilitySchedule> GetSchedules()
    {
        return AvailabilitySchedules;
    }

    public void UpdateRate(double newRate)
    {
        RentalRate rentalRate = new RentalRate();
        if (rentalRate.IsValidRate(newRate))
        {
            rentalRate.SetRate(newRate);
            RentalRates.Add(rentalRate);
            Console.WriteLine("Rental rate updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid rental rate. The rate must be greater than 0.");
        }
    }

    public void UpdateSchedule(DateTime newStartDateTime, DateTime newEndDateTime)
    {
        AvailabilitySchedule availabilitySchedule = new AvailabilitySchedule();
        if (availabilitySchedule.IsValidDate(newStartDateTime, newEndDateTime))
        {
            availabilitySchedule.SetDate(newStartDateTime, newEndDateTime);
            AvailabilitySchedules.Add(availabilitySchedule);
            Console.WriteLine("Availability schedule updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid date. The start date must be before the end date, and both must be in the future.");
        }
    }
    //Garence
}