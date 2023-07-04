using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class UserRolesMaps : BaseMap<UserRoles>
    {
        public UserRolesMaps() : base("UserRolesMaps")
        {

        }
        public override void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            base.Configure(builder);


            builder.HasKey(x => x.Id);


        }


    }
}
