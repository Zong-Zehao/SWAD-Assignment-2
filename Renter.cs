using System;

public class Renter : User
{
    private string driversLicenseNo;
    private RenterType renterType;

    private Booking booking;

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
