using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistence.Extensions;

static class ModelBuilderExtensionsRoles
{
    public static void SeedRoles(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "ED6DF2F1-C364-4361-85BE-8CFB11D6ED6B",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "5CDAFCAC-FECB-4E0A-B1E4-E406B4AF1246"
            },
            new IdentityRole
            {
                Id = "7D0EF2AA-7C3B-4543-BA96-AE509AFA3B51",
                Name = "Klient",
                NormalizedName = "KLIENT",
                ConcurrencyStamp = "BEA790A0-8837-4020-A926-C6977D662004"
            },
            new IdentityRole
            {
                Id = "5E788BC8-BB66-4584-9A05-EDC59D2D7665",
                Name = "Pracownik",
                NormalizedName = "PRACOWNIK",
                ConcurrencyStamp = "28F3A9B5-6EBC-4E93-9AC2-B93087DECCEF"
            });
    }
}
