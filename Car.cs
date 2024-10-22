﻿using System;
using System.Collections.Generic;

public class Car
{
    public int CarId { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public AvailabilitySchedule AvailabilitySchedule { get; set; }
    public RentalRate RentalRate { get; set; }
    public List<Booking> Bookings { get; set; }
    public double CurrentRate { get; set; }
    public List<AvailabilitySchedule> AvailabilitySchedules { get; set; } = new List<AvailabilitySchedule>();
    // navigation properties
    public List<DamageReport> DamageReports { get; set; }
    public List<Insurance> Insurances { get; set; }

    // Static list to hold all car instances - Zehao
    private static List<Car> cars = new List<Car>();

    public Car(int carId, string make, string model, int year, double rentalRate)
    {
        this.CarId = carId;
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.AvailabilitySchedule = new AvailabilitySchedule(carId);
        this.RentalRate = new RentalRate { Rate = rentalRate };
        this.Bookings = new List<Booking>();
        this.DamageReports = new List<DamageReport>();
        this.Insurances = new List<Insurance>();
        cars.Add(this); // Add new car to static list
    }

    public List<double> GetCurrentRates()
    {
        // Assuming the rates are stored in a list within the car object
        return new List<double> { CurrentRate };
    }

    public List<AvailabilitySchedule> GetCurrentSchedules()
    {
        // Assuming the schedules are stored in a list within the car object
        return AvailabilitySchedules;
    }

    public bool ValidateRate(double rate)
    {
        return rate > 0;
    }

    public void StoreNewRate(double rate)
    {
        CurrentRate = rate;
    }

    public bool ValidateSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        return startDateTime < endDateTime && startDateTime >= DateTime.Now;
    }

    public void StoreNewSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        AvailabilitySchedules.Add(new AvailabilitySchedule { StartDateTime = startDateTime, EndDateTime = endDateTime });
    }
}

public void UpdateAvailabilitySchedule(DateTime startDateTime, DateTime endDateTime)
    {
        if (AvailabilitySchedule == null)
        {
            AvailabilitySchedule = new AvailabilitySchedule();
        }

        AvailabilitySchedule.AddTimePeriod(startDateTime, endDateTime);
    }

    public void UpdateRate(double newRate)
    {
        if (RentalRate == null)
        {
            RentalRate = new RentalRate();
        }

        if (RentalRate.IsValidRate(newRate))
        {
            RentalRate.SetRate(newRate);
            Console.WriteLine("Rental rate updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid rental rate. The rate must be greater than 0.");
        }
    }

    // zehao's part start
    public static Car GetCarById(int carId)
    {
        return cars.Find(c => c.CarId == carId);
    }

    public void ScheduleRepair(int carId)
    {
        // Implementation for scheduling a repair
        Console.WriteLine($"Repair scheduled for car with ID: {carId}");
    }
    // zehao's part end

    public override string ToString()
    {
        return $"Car ID: {CarId}, Make: {Make}, Model: {Model}, Year: {Year}, Rate: {RentalRate?.Rate}, Availability: {AvailabilitySchedule}";
    }
}
