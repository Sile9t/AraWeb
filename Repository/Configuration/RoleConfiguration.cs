using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = "ApartmentOwner",
                    NormalizedName = "APARTMENT_OWNER"
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                },
                new IdentityRole<Guid>
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
        }
    }
}
