using System;
using System.ComponentModel.DataAnnotations;
public class Driver
{
    public int DriverID { get; set; }

    [Required(ErrorMessage = "Vehicle ID is required")]
    public int VehicleID { get; set; }

    [Required(ErrorMessage = "License plate is required")]
    public required string LicensePlate { get; set; }

    public double Rating { get; set; }

    // Other properties...
}