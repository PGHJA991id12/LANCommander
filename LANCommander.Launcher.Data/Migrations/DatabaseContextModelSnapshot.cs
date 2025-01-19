﻿// <auto-generated />
using System;
using LANCommander.Launcher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LANCommander.Launcher.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CategoryGame", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GamesId")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriesId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("CategoryGame");
                });

            modelBuilder.Entity("CollectionGame", b =>
                {
                    b.Property<Guid>("CollectionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.HasKey("CollectionId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("CollectionGame");
                });

            modelBuilder.Entity("GameDeveloper", b =>
                {
                    b.Property<Guid>("DeveloperId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.HasKey("DeveloperId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GameDeveloper");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<Guid>("GamesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("TEXT");

                    b.HasKey("GamesId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.Property<Guid>("GamesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PlatformsId")
                        .HasColumnType("TEXT");

                    b.HasKey("GamesId", "PlatformsId");

                    b.HasIndex("PlatformsId");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("GamePublisher", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId", "PublisherId");

                    b.HasIndex("PublisherId");

                    b.ToTable("GamePublisher");
                });

            modelBuilder.Entity("GameRedistributable", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RedistributableId")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId", "RedistributableId");

                    b.HasIndex("RedistributableId");

                    b.ToTable("GameRedistributable");
                });

            modelBuilder.Entity("GameTag", b =>
                {
                    b.Property<Guid>("GamesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("TEXT");

                    b.HasKey("GamesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("GameTag");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Collection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Engine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BaseGameId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EngineId")
                        .HasColumnType("TEXT");

                    b.Property<long?>("IGDBId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InstallDirectory")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Installed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InstalledOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstalledVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("LatestVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReleasedOn")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Singleplayer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SortTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BaseGameId");

                    b.HasIndex("EngineId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Library", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Crc32")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FileId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MimeType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.MultiplayerMode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NetworkProtocol")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Spectators")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("MultiplayerModes");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.PlaySession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("End")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("PlaySessions");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Redistributable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Redistributables");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AvatarId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("LibraryGame", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LibraryId")
                        .HasColumnType("TEXT");

                    b.HasKey("GameId", "LibraryId");

                    b.HasIndex("LibraryId");

                    b.ToTable("LibraryGame");
                });

            modelBuilder.Entity("CategoryGame", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CollectionGame", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Collection", null)
                        .WithMany()
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameDeveloper", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Platform", null)
                        .WithMany()
                        .HasForeignKey("PlatformsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamePublisher", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Company", null)
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameRedistributable", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Redistributable", null)
                        .WithMany()
                        .HasForeignKey("RedistributableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameTag", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Category", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Game", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", "BaseGame")
                        .WithMany("DependentGames")
                        .HasForeignKey("BaseGameId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("LANCommander.Launcher.Data.Models.Engine", "Engine")
                        .WithMany("Games")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("BaseGame");

                    b.Navigation("Engine");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Library", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.User", "User")
                        .WithOne("Library")
                        .HasForeignKey("LANCommander.Launcher.Data.Models.Library", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Media", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", "Game")
                        .WithMany("Media")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.MultiplayerMode", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", "Game")
                        .WithMany("MultiplayerModes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.PlaySession", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", "Game")
                        .WithMany("PlaySessions")
                        .HasForeignKey("GameId");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.User", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Media", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("LibraryGame", b =>
                {
                    b.HasOne("LANCommander.Launcher.Data.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LANCommander.Launcher.Data.Models.Library", null)
                        .WithMany()
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Category", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Engine", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.Game", b =>
                {
                    b.Navigation("DependentGames");

                    b.Navigation("Media");

                    b.Navigation("MultiplayerModes");

                    b.Navigation("PlaySessions");
                });

            modelBuilder.Entity("LANCommander.Launcher.Data.Models.User", b =>
                {
                    b.Navigation("Library")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
