using System.Reflection;
using Celestio.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public virtual DbSet<User> Users { get; set; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        SeedData.CreateData(modelBuilder);
    }
}