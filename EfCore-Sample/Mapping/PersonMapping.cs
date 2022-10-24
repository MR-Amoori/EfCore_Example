using EfCore_Sample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EfCore_Sample.Mapping
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("People");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).HasMaxLength(255).IsRequired();

            builder.Property(x => x.Password).HasMaxLength(15).IsRequired();


            builder.HasOne(x => x.PersonInformation).WithOne(x => x.Person)
                .HasForeignKey<PersonInformation>(x => x.PersonId);


            //  builder.Property(c => c.Password).HasDefaultValue(13522452);
        }
    }
}
