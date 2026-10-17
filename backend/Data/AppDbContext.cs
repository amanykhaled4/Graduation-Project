using Microsoft.EntityFrameworkCore;
using RetinaApi.Models;

namespace RetinaApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
}
