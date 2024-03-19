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
        
        // Seed user(s)
        UserHelper.CreatePasswordHash("Teo12345!", out byte[] passwordHash, out byte[] passwordSalt);
        builder.Entity<User>().HasData(new User
        {
            Id = 1,
            FirstName = "Teo",
            LastName = "Ivancevic",
            Email = "teo@teo.com",
            Username = "teo.ivancevic",
            RoleId = 1,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt
        });
    }
}