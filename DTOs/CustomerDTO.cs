using System.ComponentModel.DataAnnotations;
using kolokwium_apbd.Models;

namespace kolokwium_apbd.DTOs;

public class CustomerDTO
{
    [Key]
    public int CustomerId { get; set; }
    
    [Required]
    public string FirstName { get; set; }
        
    [Required]
    public string LastName { get; set; }

    public string? PhoneNumber { get; set; } = null;
    public ICollection<Models.PurchaseHistory> PurchaseHistory { get; set; } = new List<PurchaseHistory>();
}