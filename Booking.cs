using System;

public class Booking
{
    private int id;
    private string pickupOption;
    private int totalCost;

    private CarOwner carOwner;
    private Car car;
    private Renter Renter;
    private TimePeriod timePeriod;


    public Booking(int id, TimePeriod timePeriod, string pickupOption, int totalCost)
    {
        this.id = id;
        this.timePeriod = timePeriod;
        this.pickupOption = pickupOption;
        this.totalCost = totalCost;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public TimePeriod TimePeriod
    {
        get { return timePeriod; }
        set { timePeriod = value; }
    }

    public string PickupOption
    {
        get { return pickupOption; }
        set { pickupOption = value; }
    }

    public int TotalCost
    {
        get { return totalCost; }
        set { totalCost = value; }
    }

    public override string ToString()
    {
        return $"Booking ID: {id}, Time Period: {timePeriod}, " +
               $"Pickup Option: {pickupOption}, Total Cost: {totalCost}, ";
    }
}


