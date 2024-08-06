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
        if (IsValidDate(date))
        {
            Date = date;
            Console.WriteLine("Availability schedule updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid date. The date must be in the future.");
        }
    }

    public bool IsValidDate(DateTime date)
    {
        // Validate the date (e.g., date must not be in the past)
        return date > DateTime.Now;
    }
}


