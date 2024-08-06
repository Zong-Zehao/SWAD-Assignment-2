using System;
using System.Collections.Generic;

public class Renter : User
{
    private string driversLicenseNo;
    private RenterType renterType;
    private List<Booking> bookList;
    private List<DamageReport> drList;

    public Renter(string driversLicenseNo, RenterType renterType, int userId, string name, int contact, DateTime dob, string address)
        : base(userId, name, contact, dob, address)
    {
        this.driversLicenseNo = driversLicenseNo;
        this.renterType = renterType;
        this.bookList = new List<Booking>();
        this.drList = new List<DamageReport>();
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

    public List<Booking> BookList
    {
        get { return bookList; }
        set { bookList = value; }
    }

    public List<DamageReport> DrList
    {
        get { return drList; }
        set { drList = value; }
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
