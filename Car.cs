using System.Collections.Generic;

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
        // Implementation to get the current schedule
    }

    public RentalRate GetCurrentRate()
    {
        // Implementation to get the current rate
    }

    public List<AvailabilitySchedule> GetSchedules()
    {
        // Implementation to get the list of schedules
    }

    public void SetNewSchedule(AvailabilitySchedule newSchedule)
    {
        // Implementation to set a new schedule
    }

    public void SetNewRate(RentalRate newRate)
    {
        // Implementation to set a new rate
    }
}
