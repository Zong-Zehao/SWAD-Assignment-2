using System;

public class DamageReport
{
    // zehao's part start
    public int ReportId { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string ReferenceNumber { get; set; }

    // Navigation properties
    public Car Car { get; set; }
    public List<Insurance> Insurances { get; set; }

    public void CreateReport(int renterId, int carId, DateTime date, TimeSpan time, string location, string description)
    {
        // Implementation for creating a report
    }
    // zehao's part end
}

