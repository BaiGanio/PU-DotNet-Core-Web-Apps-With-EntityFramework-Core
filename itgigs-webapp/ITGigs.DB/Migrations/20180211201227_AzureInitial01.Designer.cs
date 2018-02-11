﻿// <auto-generated />
using ITGigs.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ITGigs.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180211201227_AzureInitial01")]
    partial class AzureInitial01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITGigs.ITGigService.Domain.Models.ITGig", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.Property<string>("PerformerId");

                    b.Property<int>("TicketPrice");

                    b.Property<string>("VenueId");

                    b.HasKey("Id");

                    b.HasIndex("PerformerId");

                    b.HasIndex("VenueId");

                    b.ToTable("ITGigs");
                });

            modelBuilder.Entity("ITGigs.LogService.Domain.Models.CustomException", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomInnerMessage");

                    b.Property<string>("CustomInnerStackTrace");

                    b.Property<string>("CustomMessage");

                    b.Property<string>("CustomStackTrace");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("HResult");

                    b.Property<string>("HelpLink");

                    b.Property<string>("Source");

                    b.HasKey("Id");

                    b.ToTable("CustomExceptions");
                });

            modelBuilder.Entity("ITGigs.UserService.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateChanged");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Property<string>("ValidationCode");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ITGigs.VenueService.Domain.Models.Venue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Capacity");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.Property<string>("Owner");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("ITGigs.ITGigService.Domain.Models.ITGig", b =>
                {
                    b.HasOne("ITGigs.UserService.Domain.Models.User", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerId");

                    b.HasOne("ITGigs.VenueService.Domain.Models.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId");
                });
#pragma warning restore 612, 618
        }
    }
}
