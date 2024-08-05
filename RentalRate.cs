public class RentalRate
{
    public double Rate { get; set; }

    public double GetRate()
    {
        return Rate;
    }

    public void SetRate(double rate)
    {
        Rate = rate;
    }

    public bool IsValidRate(double rate)
    {
        // Validate the rate (e.g., rate must be above a certain value)
    }
}

