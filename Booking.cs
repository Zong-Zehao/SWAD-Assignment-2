using System;

public class Booking
{
    private int bookingId;
    private DateTime startDateTime;
    private DateTime endDateTime;
    private string pickupOption;
    private int totalCost;

    private CarOwner carOwner;
    private Car car;
    private Renter renter;

    public Booking(int bookingId, DateTime startDateTime, DateTime endDateTime, string pickupOption, int totalCost)
    {
        this.bookingId = bookingId;
        this.startDateTime = startDateTime;
        this.endDateTime = endDateTime;
        this.pickupOption = pickupOption;
        this.totalCost = totalCost;
    }

    public int BookingId
    {
        get { return bookingId; }
        set { bookingId = value; }
    }

    public DateTime StartDateTime
    {
        get { return startDateTime; }
        set { startDateTime = value; }
    }

    public DateTime EndDateTime
    {
        get { return endDateTime; }
        set { endDateTime = value; }
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

    public CarOwner CarOwner
    {
        get { return carOwner; }
        set { carOwner = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public Renter Renter
    {
        get { return renter; }
        set { renter = value; }
    }

    public override string ToString()
    {
        return $"Booking ID: {bookingId}, Start: {startDateTime}, End: {endDateTime}, " +
               $"Pickup Option: {pickupOption}, Total Cost: {totalCost}, Car Owner: {carOwner.Name}, Car: {car.Id}, Renter: {renter.Name}";
    }

    public void UpdateNewRate(Car car, double newRate)
    {
        if (car.ValidateRate(newRate))
        {
            car.StoreNewRate(newRate);
            Console.WriteLine("Updated Rate: " + newRate);
        }
        else
        {
            Console.WriteLine("Invalid Rate");
        }
    }

    public void UpdateNewSchedule(Car car, DateTime startDateTime, DateTime endDateTime)
    {
        if (car.ValidateSchedule(startDateTime, endDateTime))
        {
            car.StoreNewSchedule(startDateTime, endDateTime);
            Console.WriteLine("Updated Schedule from " + startDateTime + " to " + endDateTime);
        }
        else
        {
            Console.WriteLine("Invalid Schedule");
        }
    }
}
}
