using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the iCar Rental System");
        // Main loop
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Submit Damage Report");
            Console.WriteLine("2. Manage Bookings");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 3.");
                Console.Write("Choose an option: ");
            }

            switch (option)
            {
                case 1:
                    SubmitDamageReport(renter, new List<Car> { car1, car2 });
                    break;
                case 2:
                    // Navigate to booking management
                    carOwner.NavigateToManageBookings(car1);
                    booking.DisplayBookings(car1);
                    break;
                case 3:
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
            }
        }

        carOwner.NavigateToManageBookings(car);
        booking.DisplayBookings(car);

        // Get Current Rates
        List<double> currentRates = car.GetCurrentRates();
        // Get Current Schedules
        List<AvailabilitySchedule> currentSchedules = car.GetCurrentSchedules();

        // Display Current Rates
        Console.WriteLine("Current Rental Rates:");
        foreach (var rate in currentRates)
        {
            Console.WriteLine(rate);
        }

        // Display Current Schedules
        Console.WriteLine("Current Availability Schedules:");
        foreach (var schedule in currentSchedules)
        {
            Console.WriteLine($"Start: {schedule.StartDateTime}, End: {schedule.EndDateTime}");
        }

        Console.WriteLine("Enter a new rental rate:");
        double newRate;
        while (!double.TryParse(Console.ReadLine(), out newRate))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for the rental rate:");
        }
        carOwner.SetNewRate(car, newRate);

        // Prompt user to set a new schedule
        Console.WriteLine("Enter a new start date and time (yyyy-mm-dd hh:mm):");
        DateTime newStartDateTime;
        while (!DateTime.TryParse(Console.ReadLine(), out newStartDateTime))
        {
            Console.WriteLine("Invalid input. Please enter the date and time in the format yyyy-mm-dd hh:mm:");
        }

        Console.WriteLine("Enter a new end date and time (yyyy-mm-dd hh:mm):");
        DateTime newEndDateTime;
        while (!DateTime.TryParse(Console.ReadLine(), out newEndDateTime))
        {
            Console.WriteLine("Invalid input. Please enter the date and time in the format yyyy-mm-dd hh:mm:");
        }
        carOwner.SetNewSchedule(car, newStartDateTime, newEndDateTime);
    }
}

// setting a new rate
        double newRate = 60.0;
        carOwner.SetNewRate(car, newRate);

        // Invalid rate example
        newRate = -10.0;
        carOwner.SetNewRate(car, newRate);

        // setting a new schedule
        DateTime newStartDateTime = DateTime.Now.AddDays(2);
        DateTime newEndDateTime = DateTime.Now.AddDays(3);
        carOwner.SetNewSchedule(car, newStartDateTime, newEndDateTime);

        // Invalid date example
        newStartDateTime = DateTime.Now.AddDays(-2);
        newEndDateTime = DateTime.Now.AddDays(1);
        carOwner.SetNewSchedule(car, newStartDateTime, newEndDateTime);


        // Izwan
        // Create Renter
        Renter renter = new Renter(driversLicenseNo: "D1234567", renterType: Renter.RenterType.Prime,
            userId: 1, name: "John Doe", contact: 1234567890, dob: new DateTime(1985, 5, 20), address: "561 Choa Chu Kang North 6");

        // Create a new Car object with attributes
        Car car1 = new Car(1, "Honda", "Civic", 2023, 50.0);
        Car car2 = new Car(2, "Toyota", "Corolla", 2020, 50.0);

        // Initialize AvailabilitySchedule and add time periods
        var availabilitySchedule = new AvailabilitySchedule();
        availabilitySchedule.AddTimePeriod(new DateTime(2024, 8, 1, 10, 0, 0), new DateTime(2024, 8, 7, 18, 0, 0));

        // Assign the schedule to the car
        car.AvailabilitySchedule = availabilitySchedule;
        //Izwan

    }

    // Izwan
    // Method to handle the car booking process
    public void BookCar()
    {
        // Display available time slots for car
        Console.WriteLine("Availability Schedule:");
        foreach (var period in car.AvailabilitySchedule.GetTimePeriods())
        {
            Console.WriteLine($"From {period.StartDateTime} to {period.EndDateTime}");
        }

        // Variables to store booking details
        DateTime startDateTime;
        DateTime endDateTime;
        string pickupOption;

        // Prompt user to enter booking details
        EnterBookingDetails(out startDateTime, out endDateTime, out pickupOption);

        // Check if booking is valid
        if (IsValidBooking(startDateTime, endDateTime))
        {
            // Calculate rental cost
            double rentalRate = car.CurrentRate;
            double totalCost = CalculateTotalCost(startDateTime, endDateTime, rentalRate);

            // Create a new booking object
            Booking booking = new Booking
            {
                CarId = car.CarId,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                PickupOption = pickupOption,
                TotalCost = totalCost
            };

            // Add the new booking time period to the availability schedule
            car.AddAvailability(startDateTime, endDateTime);

            // Add the booking to the car's list of bookings
            car.Bookings.Add(booking);

            // Display booking confirmation and details
            Console.WriteLine($"Booking created successfully. Total cost: ${totalCost}");
            Console.WriteLine($"Renter Details:\n Name: {renter.Name}\n Contact: {renter.Contact}");
            Console.WriteLine($"Car Details:\n Make: {car.Make}\n Model: {car.Model}\n Year: {car.Year}\n Rate: ${car.CurrentRate}/day");
            Console.WriteLine($"Booking Details:\n Start Date and Time: {booking.StartDateTime}\n End Date and Time: {booking.EndDateTime}\n Pickup Option: {booking.PickupOption}\n Total Cost: ${booking.TotalCost}");
        }
        else
        {
            // Inform the user booking is invalid
            Console.WriteLine("Invalid booking period. The dates must be within available time slots and not overlap with existing bookings.");
        }
    }

    // Method to prompt user for booking details
    private void EnterBookingDetails(out DateTime startDateTime, out DateTime endDateTime, out string pickupOption)
    {
        // Prompt user to enter start date and time
        Console.Write("Enter start date and time (yyyy-mm-dd hh:mm): ");
        while (!DateTime.TryParse(Console.ReadLine(), out startDateTime))
        {
            Console.WriteLine("Invalid start date and time format. Please try again.");
            Console.Write("Enter start date and time (yyyy-mm-dd hh:mm): ");
        }

        // Prompt user to enter end date and time
        Console.Write("Enter end date and time (yyyy-mm-dd hh:mm): ");
        while (!DateTime.TryParse(Console.ReadLine(), out endDateTime))
        {
            Console.WriteLine("Invalid end date and time format. Please try again.");
            Console.Write("Enter end date and time (yyyy-mm-dd hh:mm): ");
        }

        // Prompt user to enter pickup option
        Console.Write("Enter pickup option (e.g. pickup/delivery): ");
        pickupOption = Console.ReadLine();
    }

    // Method to check if the booking period is valid
    private bool IsValidBooking(DateTime startDateTime, DateTime endDateTime)
    {
        // Check if the booking period overlaps with any existing bookings
        foreach (var period in car.AvailabilitySchedule.GetTimePeriods())
        {
            if (startDateTime < period.EndDateTime && endDateTime > period.StartDateTime)
            {
                return false; // Booking invalid if it overlaps with any existing time period
            }
        }
        return true; // Booking valid if it does not overlap with any existing time periods
    }

    // Method to calculate the total cost of the booking
    private double CalculateTotalCost(DateTime startDateTime, DateTime endDateTime, double rate)
    {
        // Calculate duration of booking
        TimeSpan duration = endDateTime - startDateTime;
        // Calculate total cost
        double totalCost = rate * duration.TotalDays;
        return totalCost;
    }
    //Izwan

    // zehao part start

    static void SubmitDamageReport(Renter renter)
    {
        int carId;
        DateTime date;
        TimeSpan time;
        string location;
        string description;
        Car car;

        while (true)
        {
            // Prompt for all details including car ID
            carId = PromptForInt("Enter the car ID: ");
            date = PromptForDate("Enter the date of the damage (yyyy-mm-dd): ");
            time = PromptForTime("Enter the time of the damage (hh:mm): ");
            location = PromptForString("Enter the location of the damage: ");
            description = PromptForString("Enter the description of the damage: ");

            // Validate car ID
            car = Car.GetCarById(carId);

            if (car != null)
            {
                Console.WriteLine($"Car Details: Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
                break; // Exit the loop when a valid car ID is found
            }
            else
            {
                Console.WriteLine("Invalid Car ID. Please enter a valid Car ID.");
            }
        }

        // Submit the damage report when carID matches with an existing carID in the car list in car class and other inputs are correct
        try
        {
            DamageReport damageReport = new DamageReport();
            damageReport.CreateReport(renter.UserId, carId, date, time, location, description);
            Console.WriteLine("Damage report submitted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Please fill in all the details correctly and try again.");
        }
    }

    static int PromptForInt(string message)
    {
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write(message);
        }
        return result;
    }

    static DateTime PromptForDate(string message)
    {
        Console.Write(message);
        while (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            Console.WriteLine("Invalid date format. Please try again.");
            Console.Write(message);
        }
        return date;
    }

    static TimeSpan PromptForTime(string message)
    {
        Console.Write(message);
        while (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
        {
            Console.WriteLine("Invalid time format. Please try again.");
            Console.Write(message);
        }
        return time;
    }

    static string PromptForString(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.Write(message);
        }
        return input;
    }
    // zehao part end
}
