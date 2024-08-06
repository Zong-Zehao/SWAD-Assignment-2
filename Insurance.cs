using System;

public class Insurance
{
    // Zehao's part start
    public int InsuranceId { get; set; }
    public int CarId { get; set; }
    public int UserId { get; set; }
    public string CoverageDetails { get; set; }

    // Navigation properties
    public Car Car { get; set; }
    public Renter Renter { get; set; }
    public List<DamageReport> DamageReports { get; set; }
    // Zehao's part end
}