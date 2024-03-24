using Celestio.Api.Data.Entities;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Data;

public class SeedData
{
    public static void CreateData(ModelBuilder builder)
    {
        // Seed roles
        builder.Entity<Role>().HasData(new Role[]
        {
            new Role
            {
                Id = 1,
                Name = "SuperAdmin"
            },
            new Role
            {
                Id = 2,
                Name = "AgencyAdmin"
            },
            new Role
            {
                Id = 3,
                Name = "Creator"
            },
            new Role
            {
                Id = 4,
                Name = "User"
            },
            new Role
            {
                Id = 5,
                Name = "BrandAdmin" // administrator for single brand
            }
        });
        
        builder.Entity<Company>().HasData(new Company
        {
            Id = 1,
            CompanyName = "Celestio",
            CompanyDescription = "Celestio Content description woo",
            ContactEmail = "celestio.dev@gmail.com",
            Type = CompanyType.Celestio,
            ProfilePicMediaId = 1
        }, new Company
        {
            Id = 2,
            CompanyName = "Agency 404",
            CompanyDescription = "Agencija 404 za kreatore",
            ContactEmail = "contact@404.com",
            Type = CompanyType.Agency,
            ProfilePicMediaId = 1
        });
        
        // seed media
        builder.Entity<Media>().HasData(new Media
        {
            Id = 1,
            MediaType = "aaa",
            MediaUrl = "lasbd url media"
        });

        // Seed user(s)
        UserHelper.CreatePasswordHash("Teo12345!", out byte[] passwordHash1, out byte[] passwordSalt1);
        UserHelper.CreatePasswordHash("Leonarda12345!", out byte[] passwordHash2, out byte[] passwordSalt2);
        builder.Entity<User>().HasData(new User
        {
            Id = 1,
            FirstName = "Teo",
            LastName = "Ivančević (č, ć, dž, đ, š, ž)",
            UserDescription = "Ja sam teo bla bla",
            Email = "teo@teo.com",
            CompanyId = 1,
            RoleId = 1,
            ProfilePicMediaId = 1,
            PasswordHash = passwordHash1,
            PasswordSalt = passwordSalt1
        }, new User
        {
            Id = 2,
            FirstName = "Leonarda",
            LastName = "Lovrić",
            UserDescription = "Ja sam leonarda bla bla",
            Email = "leonarda@404.com",
            CompanyId = 2,
            RoleId = 2,
            ProfilePicMediaId = 1,
            PasswordHash = passwordHash2,
            PasswordSalt = passwordSalt2
        });
    }
}