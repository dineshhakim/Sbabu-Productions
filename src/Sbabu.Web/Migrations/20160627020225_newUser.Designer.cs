using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Sbabu.Web.Repository.Infrastructure;

namespace Sbabu.Web.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20160627020225_newUser")]
    partial class newUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sbabu.Web.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "NVARCHAR");

                    b.Property<string>("BusinessHours")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<string>("ContactNo")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500)
                        .HasAnnotation("Relational:ColumnType", "NVARCHAR");

                    b.Property<string>("EmaildId")
                        .HasAnnotation("MaxLength", 50);

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "NVARCHAR");

                    b.Property<string>("State")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<string>("WebsiteLink")
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<string>("ZipCode")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "Company");
                });

            modelBuilder.Entity("Sbabu.Web.Models.SocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Sbabu.Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "NVARCHAR");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "NVARCHAR");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "VARCHAR");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "Users");
                });

            modelBuilder.Entity("Sbabu.Web.Models.SocialNetwork", b =>
                {
                    b.HasOne("Sbabu.Web.Models.Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
