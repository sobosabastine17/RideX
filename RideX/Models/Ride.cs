using System;
using System.ComponentModel.DataAnnotations;
public class Ride
{
    public int RideID { get; set; }

    [Required(ErrorMessage = "Rider ID is required")]
    public int RiderID { get; set; }

    [Required(ErrorMessage = "Driver ID is required")]
    public int DriverID { get; set; }

    [Required(ErrorMessage = "Pickup location is required")]
    public required string PickupLocation { get; set; }

    [Required(ErrorMessage = "Dropoff location is required")]
    public required string DropoffLocation { get; set; }

    public required string RideStatus { get; set; }
    public decimal Fare { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; } // Nullable for ongoing rides
    // Other properties...
}