﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using server.Repositories;
using System;

namespace server.Migrations
{
    [DbContext(typeof(NewsApiContext))]
    [Migration("20180719025528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("server.Models.News", b =>
                {
                    b.Property<string>("NewsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Category");

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<string>("Id");

                    b.Property<string>("Language");

                    b.Property<DateTime>("PublishedAt");

                    b.Property<string>("SourceId");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("UrlToImage");

                    b.HasKey("NewsId");

                    b.HasIndex("SourceId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("server.Models.Source", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("server.Models.News", b =>
                {
                    b.HasOne("server.Models.Source", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId");
                });
#pragma warning restore 612, 618
        }
    }
}
