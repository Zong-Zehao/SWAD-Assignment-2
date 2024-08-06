using System;

public class AvailabilitySchedule
{
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public DateTime GetDate()
    {
        return StartDateTime;
    }

    public void SetDate(DateTime startDateTime, DateTime endDateTime)
    {
        if (IsValidDate(startDateTime, endDateTime))
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Console.WriteLine("Availability schedule updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid date. The start date must be before the end date, and both must be in the future.");
        }
    }

    public bool IsValidDate(DateTime startDateTime, DateTime endDateTime)
    {
        return startDateTime < endDateTime && startDateTime > DateTime.Now && endDateTime > DateTime.Now;
    }
}



