﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tictactoe_server.Models;

namespace tictactoe_server.Migrations
{
    [DbContext(typeof(TicTacToeContext))]
    partial class TicTacToeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("tictactoe_server.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PlayerOneId");

                    b.Property<int?>("PlayerTwoId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerOneId");

                    b.HasIndex("PlayerTwoId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("tictactoe_server.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Marker");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("tictactoe_server.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GameId");

                    b.Property<int>("Index");

                    b.Property<string>("Marker");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("tictactoe_server.Models.Game", b =>
                {
                    b.HasOne("tictactoe_server.Models.Player", "PlayerOne")
                        .WithMany()
                        .HasForeignKey("PlayerOneId");

                    b.HasOne("tictactoe_server.Models.Player", "PlayerTwo")
                        .WithMany()
                        .HasForeignKey("PlayerTwoId");
                });

            modelBuilder.Entity("tictactoe_server.Models.Position", b =>
                {
                    b.HasOne("tictactoe_server.Models.Game", "Game")
                        .WithMany("Positions")
                        .HasForeignKey("GameId");
                });
#pragma warning restore 612, 618
        }
    }
}
