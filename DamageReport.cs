using System;

public class DamageReport
{
    // zehao's part start
    public int ReportId { get; set; }
    public int UserId { get; set; }
    public int CarId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string ReferenceNumber { get; set; }

    // Navigation properties
    public Car Car { get; set; }
    public List<Insurance> Insurances { get; set; }

    public void CreateReport(int renterId, int carId, DateTime date, TimeSpan time, string location, string description)
    {
        // Step 1: Assign properties
        UserId = renterId;
        CarId = carId;
        Date = date;
        Time = time;
        Location = location;
        Description = description;

        // Step 2: Validate CarId and retrieve Car information
        Car = new Car(carId, "", "", 0, 0); // Replace with real implementation to fetch the car by ID
        Car = Car.GetCarById();

        if (Car == null)
        {
            // Handle invalid CarId
            throw new Exception("Invalid CarId. Please check the details and try again.");
        }

        // Step 3: Fetch Insurance for the Car
        Insurances = new List<Insurance> { Car.GetInsurance(carId, "Full Coverage") };

        // Step 4: Initiate the insurance claim process
        foreach (var insurance in Insurances)
        {
            insurance.ScheduleRepair(carId);
        }

        // Step 5: Display confirmation to the renter
        DisplayConfirmation();
    }

    private void DisplayConfirmation()
    {
        // Implementation to display confirmation message to the renter
        Console.WriteLine("Damage report created successfully.");
    }
    // zehao's part end
}

