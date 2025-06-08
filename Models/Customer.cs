using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Models;

[Table("Customer")]
[PrimaryKey(nameof(CustomerId))]
public class Customer {
    public int CustomerId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string? PhoneNumber { get; set; }

    public ICollection<PurchaseHistory> purchaseHistory { get; set; } = null!;
}