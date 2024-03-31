using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestio.Api.Data.Entities;

public class Media
{
    public int Id { get; set; }
    public string MediaUrl { get; set; }
    public string MediaType { get; set; }
    
    public DateTime Created { get; set; } = DateTime.Now;
    
    public virtual Brand Brand { get; set; }
}

public class MediaConfigurationBuilder : IEntityTypeConfiguration<Media>
{
    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.ToTable(nameof(Role));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MediaUrl)
            .IsRequired();
        builder.Property(x => x.MediaType)
            .IsRequired();
        builder.Property(x => x.Created)
            .IsRequired();
    }
}