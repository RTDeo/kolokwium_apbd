using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium_apbd.Models;

[Table("Purchase_History")]
[PrimaryKey(nameof(AvailableProgramId), nameof(CustomerId))]
public class PurchaseHistory {
    [ForeignKey(nameof(AvailableProgram))]
    public int AvailableProgramId { get; set; }
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int? Rating { get; set; }
}