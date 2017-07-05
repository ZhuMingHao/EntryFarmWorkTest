using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EntryFarmWorkTest;

namespace EntryFarmWorkTest.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20170705055058_DBMigration")]
    partial class DBMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("EntryFarmWorkTest.CourseLeadersView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseCode");

                    b.Property<int>("SCLAppNo");

                    b.Property<string>("SchoolName");

                    b.HasKey("Id");

                    b.ToTable("GroupLeadersViews");
                });
        }
    }
}
