﻿// <auto-generated />
using System;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatingApp.API.Models.Like", b =>
                {
                    b.Property<int>("LikerId")
                        .HasColumnType("int");

                    b.Property<int>("LikeeId")
                        .HasColumnType("int");

                    b.HasKey("LikerId", "LikeeId");

                    b.HasIndex("LikeeId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DatingApp.API.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("DatingApp.API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("DatingApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KnownAs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LookingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DatingApp.API.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("DatingApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Action", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasKey("ActionId");

                    b.HasIndex("ProcessId");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.ActionTarget", b =>
                {
                    b.Property<int>("ActionTargetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<int>("TargetUserId")
                        .HasColumnType("int");

                    b.HasKey("ActionTargetId");

                    b.HasIndex("ActionId");

                    b.ToTable("ActionTargets");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Process", b =>
                {
                    b.Property<int>("ProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProcessName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProcessId");

                    b.ToTable("Processs");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentStateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<string>("Tile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.HasIndex("CurrentStateId");

                    b.HasIndex("ProcessId");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.RequestAction", b =>
                {
                    b.Property<int>("RequestActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<int>("TransitionId")
                        .HasColumnType("int");

                    b.HasKey("RequestActionId");

                    b.HasIndex("ActionId");

                    b.HasIndex("RequestId");

                    b.HasIndex("TransitionId");

                    b.ToTable("RequestActions");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("StateTypeId")
                        .HasColumnType("int");

                    b.HasKey("StateId");

                    b.HasIndex("ProcessId");

                    b.HasIndex("StateTypeId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.StateType", b =>
                {
                    b.Property<int>("StateTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateTypeId");

                    b.ToTable("StateTypes");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Transition", b =>
                {
                    b.Property<int>("TransitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentStateId")
                        .HasColumnType("int");

                    b.Property<int>("NextStateId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.HasKey("TransitionId");

                    b.HasIndex("CurrentStateId");

                    b.HasIndex("NextStateId");

                    b.HasIndex("ProcessId");

                    b.ToTable("Transitions");
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.TransitionAction", b =>
                {
                    b.Property<int>("TransitionId")
                        .HasColumnType("int");

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.HasKey("TransitionId", "ActionId");

                    b.HasIndex("ActionId");

                    b.ToTable("TransitionActions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DatingApp.API.Models.Like", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "Likee")
                        .WithMany("Likers")
                        .HasForeignKey("LikeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.User", "Liker")
                        .WithMany("Likees")
                        .HasForeignKey("LikerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.Models.Message", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.User", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.Models.UserRole", b =>
                {
                    b.HasOne("DatingApp.API.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Action", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.Process", "Process")
                        .WithMany("Actions")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.ActionTarget", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.Action", "Action")
                        .WithMany("ActionTargets")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Request", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.State", "CurrentState")
                        .WithMany("Requests")
                        .HasForeignKey("CurrentStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.Process", "Process")
                        .WithMany("Requests")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.Models.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.RequestAction", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.Action", "Action")
                        .WithMany("RequestActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.Request", "Request")
                        .WithMany("RequestActions")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.Transition", "Transition")
                        .WithMany("RequestActions")
                        .HasForeignKey("TransitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.State", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.Process", "Process")
                        .WithMany("States")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.StateType", "StateType")
                        .WithMany("States")
                        .HasForeignKey("StateTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.Transition", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.State", "CurrentState")
                        .WithMany("Transitionnexts")
                        .HasForeignKey("CurrentStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.State", "NextState")
                        .WithMany("Transitioncurrents")
                        .HasForeignKey("NextStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.Process", "Process")
                        .WithMany("Transitions")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DatingApp.API.WorkFlowModels.TransitionAction", b =>
                {
                    b.HasOne("DatingApp.API.WorkFlowModels.Action", "Action")
                        .WithMany("TransititionActions")
                        .HasForeignKey("ActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatingApp.API.WorkFlowModels.Transition", "Transition")
                        .WithMany("TransititionActions")
                        .HasForeignKey("TransitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("DatingApp.API.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
