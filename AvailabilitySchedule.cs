﻿using System;
using System.Collections.Generic;

public class AvailabilitySchedule
{
    public int CarId { get; set; } // Link AvailabilitySchedule to Car
    private List<(DateTime StartDateTime, DateTime EndDateTime)> timePeriods { get; set; }

    public AvailabilitySchedule(int carId)
    {
        CarId = carId;
        TimePeriods = new List<(DateTime, DateTime)>();
    }

    public void AddTimePeriod(DateTime startDateTime, DateTime endDateTime)
    {
        if (IsValidDate(startDateTime, endDateTime))
        {
            timePeriods.Add((startDateTime, endDateTime));
            Console.WriteLine("Time period added successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid date. The start date must be before the end date, and both must be in the future.");
        }
    }

    public List<(DateTime StartDateTime, DateTime EndDateTime)> GetTimePeriods()
    {
        return timePeriods;
    }

    public bool IsValidDate(DateTime startDateTime, DateTime endDateTime)
    {
        return startDateTime < endDateTime && startDateTime > DateTime.Now && endDateTime > DateTime.Now;
    }

    public DateTime StartDateTime { get; private set; }
    public DateTime EndDateTime { get; private set; }

    public AvailabilitySchedule(DateTime startDateTime, DateTime endDateTime)
    {
        if (ValidateSchedule(startDateTime, endDateTime))
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }
        else
        {
            throw new ArgumentException("Invalid schedule. Start date must be before end date and not in the past.");
        }
    }

    public bool ValidateSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        return startDateTime < endDateTime && startDateTime >= DateTime.Now;
    }

    public void UpdateSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        if (ValidateSchedule(startDateTime, endDateTime))
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }
        else
        {
            throw new ArgumentException("Invalid schedule. Start date must be before end date and not in the past.");
        }
    }
} 


}
