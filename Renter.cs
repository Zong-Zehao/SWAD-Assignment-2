using System;

public class Renter : User
{
    private string driversLicenseNo;
    private RenterType renterType;

    private List<Booking> bookList;

    private List<DamageReport> drList

    public Renter(string driversLicenseNo, RenterType renterType, int id, string name, int contact, DateTime dob)
        : base(id, name, contact, dob)
    {
        this.driversLicenseNo = driversLicenseNo;
        this.renterType = renterType;
        this.bookList = new List<Booking>(); // Initialize the list of bookings
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
        return $"{base.ToString()}, Driver's License No: {driversLicenseNo}, Renter Type: {renterType}";
    }
}
