using Microsoft.EntityFrameworkCore;
using kolokwium_apbd.Models;
using System.Security.Cryptography.X509Certificates;

namespace kolokwium_apbd.Data;

public class DatabaseContext : DbContext
{

    public DbSet<Models.WashingMachine> WashingMachines { get; set; }
    public DbSet<Models.Customer> Customers { get; set; }
    public DbSet<Models.Program> Programs { get; set; }
    public DbSet<Models.AvailableProgram> AvailablePrograms { get; set; }
    public DbSet<Models.PurchaseHistory> PurchaseHistories { get; set; }
    protected DatabaseContext() {}
    public DatabaseContext(DbContextOptions options) : base(options) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Program>().HasData(new List<Models.Program>() {
            new Models.Program() {
                ProgramId = 1,
                Name = "Something",
                DurationMinutes = 10,
                TemperatureCelsius = 30
            }
        });

        modelBuilder.Entity<Models.AvailableProgram>().HasData(new List<Models.AvailableProgram>() {
            new Models.AvailableProgram() {
                AvailableProgramId = 1,
                WashingMachineId = 1,
                ProgramId = 1,
                Price = 200,
            }
        });

        modelBuilder.Entity<Models.WashingMachine>().HasData(new List<Models.WashingMachine>() {
            new Models.WashingMachine() {
                 WashingMachineId = 1,
                 MaxWeight = 500,
                 SerialNumber = "255335836"
            }
        });

        modelBuilder.Entity<Models.PurchaseHistory>().HasData(new List<Models.PurchaseHistory>() {
            new PurchaseHistory() {
                AvailableProgramId = 1,
                CustomerId = 1,
                PurchaseDate = DateTime.Parse("05/05/2020"),
                Rating = 5
            }
        });

        modelBuilder.Entity<Models.Customer>().HasData(new List<Models.Customer>() {
            new Customer() {
                CustomerId = 1,
                FirstName = "Bob",
                LastName = "Smith",
                PhoneNumber = "111222333"
            }
        });
    }


}