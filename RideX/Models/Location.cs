using System;
using System.ComponentModel.DataAnnotations;
public class Location
{
    public int LocationID { get; set; }

    [Required(ErrorMessage = "Latitude is required")]
    public double Latitude { get; set; }

    [Required(ErrorMessage = "Longitude is required")]
    public double Longitude { get; set; }

    public required string Address { get; set; }
    // Other properties...
}