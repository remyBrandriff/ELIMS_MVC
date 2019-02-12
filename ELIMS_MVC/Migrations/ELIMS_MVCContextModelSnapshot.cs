﻿// <auto-generated />
using System;
using ELIMS_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ELIMS_MVC.Migrations
{
    [DbContext(typeof(ELIMS_MVCContext))]
    partial class ELIMS_MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ELIMS_MVC.Models.ContactForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("NAUEmail")
                        .IsRequired();

                    b.Property<string>("Topic")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ContactForm");
                });

            modelBuilder.Entity("ELIMS_MVC.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chemicals");

                    b.Property<int>("ContactID");

                    b.Property<string>("ContactName")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Funding");

                    b.Property<string>("GroupMembers");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MeetingTimes");

                    b.Property<string>("NAUEmail");

                    b.Property<string>("ProjectFile");

                    b.Property<string>("ProjectName");

                    b.Property<string>("ProjectObjective");

                    b.Property<DateTime>("RequestMade")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("RequestStatus")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Pending");

                    b.Property<string>("SponsorEmail");

                    b.Property<string>("SponsorName");

                    b.Property<string>("SponsorPhone");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Request");
                });
#pragma warning restore 612, 618
        }
    }
}