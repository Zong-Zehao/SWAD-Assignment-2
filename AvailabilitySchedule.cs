using System;

public class AvailabilitySchedule
{
    public DateTime Date { get; set; }

    public DateTime GetDate()
    {
        return Date;
    }

    public void SetDate(DateTime date)
    {
        Date = date;
    }

    public bool IsValidDate(DateTime date)
    {
        // Validate the date (e.g., date must not be in the past)
    }
}
