using System;
using System.Collections.Generic;

public class Insurance
{
    public int InsuranceId { get; set; }
    public int CarId { get; set; }
    public int UserId { get; set; }
    public string CoverageDetails { get; set; }

    // Navigation properties
    public Car Car { get; set; }
    public List<DamageReport> DamageReports { get; set; }

    public Insurance GetInsurance(int insuranceId, string coverageDetails)
    {
        // Implementation for getting insurance details
        return this;
    }

    public void ScheduleRepair(int carId)
    {
        // Implementation for scheduling a repair
        Console.WriteLine($"Repair scheduled for car with ID: {carId}");
    }
}
