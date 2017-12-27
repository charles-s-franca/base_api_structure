﻿// <auto-generated />
using Letsworkout.Api.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Letsworkout.Api.Migrations
{
    [DbContext(typeof(LetsWorkoutContext))]
    partial class LetsWorkoutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Letsworkout.Api.Infrastructure.Model.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("birthday");

                    b.Property<DateTime>("createdAt");

                    b.Property<string>("lastname");

                    b.Property<string>("name");

                    b.Property<DateTime>("updatedAt");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Letsworkout.Api.Infrastructure.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("createdAt");

                    b.Property<string>("password");

                    b.Property<DateTime>("updatedAt");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
