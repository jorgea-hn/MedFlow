using MedFlow.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MedFlow.Web.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Affiliate> Affiliates { get; set; }
    public DbSet<Turn> Turns { get; set; }
    public DbSet<CashDesk> CashDesks { get; set; }
    public DbSet<Employee> Employees { get; set; }
    
}