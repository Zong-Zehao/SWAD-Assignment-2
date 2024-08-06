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
    public List<string> Photos { get; set; }
    public string ReferenceNumber { get; set; }

    // Navigation properties
    public Renter Renter { get; set; }
    public Car Car { get; set; }
    public List<Insurance> Insurances { get; set; }
    // zehao's part end
}

