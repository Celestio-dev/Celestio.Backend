using Celestio.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestio.Api.Data.Entities;

public class SocialMedia
{
    public int Id { get; set; }
    public int DocId { get; set; }
    public string TableName { get; set; }
    public SocialMediaEnum SocialMediaName { get; set; }
    public string SocialMediaUsername { get; set; }
    public string SocialMediaUrl { get; set; }
    public int? FollowerCount { get; set; }
    public DateTime Created { get; set; }
    
    //public virtual Brand Brand { get; set; }
}

public class SocialMediaConfigurationBuilder : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable(nameof(SocialMedia));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DocId)
            .IsRequired();
        builder.Property(x => x.TableName)
            .IsRequired();
        builder.Property(x => x.SocialMediaName)
            .IsRequired();
        builder.Property(x => x.SocialMediaUsername)
            .IsRequired();
        builder.Property(x => x.SocialMediaUrl)
            .IsRequired();
        builder.Property(x => x.FollowerCount)
            .IsRequired(false);
        builder.Property(x => x.Created)
            .HasDefaultValue(DateTime.UtcNow)
            .IsRequired();
    }
}
