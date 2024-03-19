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
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<SocialMediaUrl> SocialMediaUrls { get; set; }
    public virtual DbSet<UserCategory> UserCategories { get; set; }
    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<CompanyBrand> CompanyBrands { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<Brief> Briefs { get; set; }
    public virtual DbSet<Submission> Submissions { get; set; }
    public virtual DbSet<Media> Media { get; set; }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        SeedData.CreateData(modelBuilder);
    }
}