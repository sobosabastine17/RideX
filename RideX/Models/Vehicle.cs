using System;
using System.ComponentModel.DataAnnotations;
public class Vehicle
{
    public int VehicleID { get; set; }

    [Required(ErrorMessage = "Make is required")]
    public required string Make { get; set; }

    [Required(ErrorMessage = "Model is required")]
    public required string Model { get; set; }

    [Required(ErrorMessage = "Year is required")]
    public int Year { get; set; }

    public required string Color { get; set; }

    // Other properties...
}