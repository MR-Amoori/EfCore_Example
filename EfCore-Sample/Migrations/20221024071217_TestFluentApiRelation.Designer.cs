// <auto-generated />
using EfCore_Sample.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCore_Sample.Migrations
{
    [DbContext(typeof(EfCoreContext))]
    [Migration("20221024071217_TestFluentApiRelation")]
    partial class TestFluentApiRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCore_Sample.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Password = "Mramoori021_@",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("EfCore_Sample.Models.PersonInformation", b =>
                {
                    b.Property<int>("PersonInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonInfoId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonInfoId");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("PersonInformation", (string)null);

                    b.HasData(
                        new
                        {
                            PersonInfoId = 1,
                            Age = 17,
                            PersonId = 1,
                            PhoneNumber = "09035170373"
                        });
                });

            modelBuilder.Entity("EfCore_Sample.Models.PersonInformation", b =>
                {
                    b.HasOne("EfCore_Sample.Models.Person", "Person")
                        .WithOne("PersonInformation")
                        .HasForeignKey("EfCore_Sample.Models.PersonInformation", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("EfCore_Sample.Models.Person", b =>
                {
                    b.Navigation("PersonInformation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
