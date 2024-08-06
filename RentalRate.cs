public class RentalRate
{
    public double Rate { get; set; }

    public double GetRate()
    {
        return Rate;
    }

    public void SetRate(double rate)
    {
        if (IsValidRate(rate))
        {
            Rate = rate;
            Console.WriteLine("Rental rate updated successfully.");
        }
        else
        {
            Console.WriteLine("Error: Invalid rental rate. The rate must be greater than 0.");
        }
    }

    public bool IsValidRate(double rate)
    {
        // Validate the rate (e.g., rate must be above a certain value)
        return rate > 0;
    }
}



