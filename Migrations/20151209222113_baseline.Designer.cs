using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using ASPNET5_EF7_Test;

namespace ASPNET5_EF7_Test.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20151209222113_baseline")]
    partial class baseline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNET5_EF7_Test.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnName", "UserId");

                    b.Property<string>("FirstName");

                    b.HasKey("Id");
                });
        }
    }
}
