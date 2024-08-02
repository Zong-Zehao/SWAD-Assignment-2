using System;

public class Booking
{
    private int id;
    private DateTime startDate;
    private TimeSpan startTime;
    private DateTime endDate;
    private TimeSpan endTime;
    private string pickupOption;
    private int totalCost;

    private Renter renter;
    private Car car;

    public Booking(int id, DateTime startDate, TimeSpan startTime,
                   DateTime endDate, TimeSpan endTime, string pickupOption, int totalCost)
    {
        this.id = id;
        this.startDate = startDate;
        this.startTime = startTime;
        this.endDate = endDate;
        this.endTime = endTime;
        this.pickupOption = pickupOption;
        this.totalCost = totalCost;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public DateTime StartDate
    {
        get { return startDate; }
        set { startDate = value; }
    }

    public TimeSpan StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    public DateTime EndDate
    {
        get { return endDate; }
        set { endDate = value; }
    }

    public TimeSpan EndTime
    {
        get { return endTime; }
        set { endTime = value; }
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
        return $"Booking ID: {id}, Start Date: {startDate.ToShortDateString()}, " +
               $"Start Time: {startTime}, End Date: {endDate.ToShortDateString()}, End Time: {endTime}, " +
               $"Pickup Option: {pickupOption}, Total Cost: {totalCost}";
    }
}
