﻿// <auto-generated />
using System;
using MetanoiaCoreAPI.Infa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace test_project2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200925144437_database")]
    partial class database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("MetanoiaCoreAPI.AdminUser.AdminUserDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("AdminUserDTOs");
                });

            modelBuilder.Entity("MetanoiaCoreAPI.AppUser.AppUserDTO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Hobbies")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobRole")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("PsychologyCausesID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PsychologyEffectsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RelationshipStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Religion")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PsychologyCausesID");

                    b.HasIndex("PsychologyEffectsID");

                    b.ToTable("AppUserDTOs");
                });

            modelBuilder.Entity("MetanoiaCoreAPI.AppUser.UserPsychologyCauses", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ClingtoSomething")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FamilyConflict")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LossingSomeone")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Rape")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RelationshipProblem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SexualAbuse")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WorkProblem")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("UserPsychologyCauses");
                });

            modelBuilder.Entity("MetanoiaCoreAPI.AppUser.UserPsychologyEffects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AngerProblem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ConstantWorry")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FeelingOverWhelmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FeelingSadORDown")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FocusProblem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LonelinessORIsolation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LossofAppetite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MoodSwing")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NoJoy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OveruseOfAlcholAndDrugs")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SexDriveChange")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SleepProblem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SuicidalThoughts")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Unhappiness")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WeightLossORWeightGain")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WithdrawFromFriendsORActivities")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("UserPsychologyEffects");
                });

            modelBuilder.Entity("MetanoiaCoreAPI.AppUser.AppUserDTO", b =>
                {
                    b.HasOne("MetanoiaCoreAPI.AppUser.UserPsychologyCauses", "PsychologyCauses")
                        .WithMany()
                        .HasForeignKey("PsychologyCausesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MetanoiaCoreAPI.AppUser.UserPsychologyEffects", "PsychologyEffects")
                        .WithMany()
                        .HasForeignKey("PsychologyEffectsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PsychologyCauses");

                    b.Navigation("PsychologyEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
