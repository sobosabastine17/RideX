using System;
using System.ComponentModel.DataAnnotations;
public class Rider
{
    public int RiderID { get; set; }

    [Required(ErrorMessage = "Payment info is required")]
    public required string PaymentInfo { get; set; }

    // Other properties...
}