using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EntryFarmWorkTest;

namespace EntryFarmWorkTest.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
