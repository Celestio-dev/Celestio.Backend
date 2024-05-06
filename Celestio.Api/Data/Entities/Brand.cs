using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestio.Api.Data.Entities;

public class Brand
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public string BrandDescription { get; set; }
    public int? ProfilePicMediaId { get; set; }
    public int CompanyId { get; set; }
    
    public DateTime Created { get; set; }
    
    public virtual Company Company { get; set; }
    public virtual Media? ProfilePicMedia { get; set; }
    
    public virtual ICollection<Brief> Briefs { get; set; }
    
    public virtual ICollection<SocialMedia> SocialMediae { get; set; }

}

public class BrandConfigurationBuilder : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable(nameof(Brand));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BrandName)
            .IsRequired();
        builder.Property(x => x.BrandDescription)
            .IsRequired();
        builder.Property(x => x.ProfilePicMediaId)
            .IsRequired(false);
        builder.Property(x => x.CompanyId)
            .IsRequired();
        builder.Property(x => x.Created)
            .IsRequired();
        

        builder.HasOne(b => b.ProfilePicMedia)
            .WithOne(m => m.Brand)
            .HasForeignKey<Brand>(b => b.ProfilePicMediaId)
            .IsRequired(false);
        
        builder.HasOne(b => b.Company)
            .WithMany(m => m.Brands)
            .HasForeignKey(b => b.CompanyId)
            .IsRequired();
        
        
    }
}