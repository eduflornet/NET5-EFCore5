using Fluent.API.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fluent.API.DAL.Configurations
{
    internal class PriceOfferConfig : IEntityTypeConfiguration<PriceOffer>
    {
        public void Configure(EntityTypeBuilder<PriceOffer> entity)
        {
            //automated
            // entity.Property(p => p.NewPrice)
                //.HasColumnType("decimal(9,2)");
        }
    }
}
