using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore_Sample.Mapping
{
    public class PersonInformationMapping : IEntityTypeConfiguration<PersonInformation>
    {
        public void Configure(EntityTypeBuilder<PersonInformation> builder)
        {
            builder.ToTable("PersonInformation");

            builder.HasKey(x => x.PersonInfoId);

            //builder.HasOne(x => x.Person).WithOne(x => x.PersonInformation)
            //    .HasForeignKey<Person>(x => x.PersonInfoId);
        }
    }
}
