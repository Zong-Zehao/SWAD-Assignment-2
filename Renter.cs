using System;

public class Renter : User
{
    private string driversLicenseNo;
    private RenterType renterType;

    private Booking booking;

    // zehao's part start
    public string FullName { get; set; }
    public string ContactDetails { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int UserId { get; set; }
    // Navigation property
    public List<DamageReport> DamageReports { get; set; }
    // zehao's part end


    public Renter(string driversLicenseNo, RenterType renterType)
    {
        this.driversLicenseNo = driversLicenseNo;
        this.renterType = renterType;
    }

    public string DriversLicenseNo
    {
        get { return driversLicenseNo; }
        set { driversLicenseNo = value; }
    }

    public RenterType RenterType
    {
        get { return renterType; }
        set { renterType = value; }
    }

    public Booking Booking
    {
        get { return booking; }
        set { booking = value; }
    }

    public enum RenterType
    {
        Prime,
        Regular
    }

    public override string ToString()
    {
        return $"Driver's License No: {driversLicenseNo}, Renter Type: {renterType}";
    }
}
