﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pantry.Core.Models.EanSearchOrg;
using Pantry.Core.Models.OpenFoodFacts;
using Pantry.Core.Persistence;

#nullable disable

namespace Pantry.Core.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Account", b =>
                {
                    b.Property<long>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("account_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("AccountId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<Guid>("FriendsCode")
                        .HasColumnType("uuid")
                        .HasColumnName("friends_code");

                    b.Property<long?>("HouseholdId")
                        .HasColumnType("bigint")
                        .HasColumnName("household_id");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("OAuhtId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("o_auht_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("AccountId")
                        .HasName("pk_accounts");

                    b.HasIndex("HouseholdId")
                        .HasDatabaseName("ix_accounts_household_id");

                    b.HasIndex("OAuhtId")
                        .IsUnique()
                        .HasDatabaseName("ix_accounts_o_auht_id");

                    b.ToTable("accounts", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Article", b =>
                {
                    b.Property<long>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("article_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ArticleId"));

                    b.Property<DateTime>("BestBeforeDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("best_before_date");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<int>("ContentType")
                        .HasColumnType("integer")
                        .HasColumnName("content_type");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("GlobalTradeItemNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("global_trade_item_number");

                    b.Property<long>("HouseholdId")
                        .HasColumnType("bigint")
                        .HasColumnName("household_id");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<long>("StorageLocationId")
                        .HasColumnType("bigint")
                        .HasColumnName("storage_location_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("ArticleId")
                        .HasName("pk_articles");

                    b.HasIndex("BestBeforeDate")
                        .HasDatabaseName("ix_articles_best_before_date");

                    b.HasIndex("GlobalTradeItemNumber")
                        .HasDatabaseName("ix_articles_global_trade_item_number");

                    b.HasIndex("HouseholdId")
                        .HasDatabaseName("ix_articles_household_id");

                    b.HasIndex("StorageLocationId")
                        .HasDatabaseName("ix_articles_storage_location_id");

                    b.ToTable("articles", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Device", b =>
                {
                    b.Property<long>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("device_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("DeviceId"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint")
                        .HasColumnName("account_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("DeviceToken")
                        .HasColumnType("text")
                        .HasColumnName("device_token");

                    b.Property<Guid>("InstallationId")
                        .HasColumnType("uuid")
                        .HasColumnName("installation_id");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Platform")
                        .HasColumnType("integer")
                        .HasColumnName("platform");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("DeviceId")
                        .HasName("pk_devices");

                    b.HasIndex("AccountId")
                        .HasDatabaseName("ix_devices_account_id");

                    b.HasIndex("DeviceToken")
                        .IsUnique()
                        .HasDatabaseName("ix_devices_device_token");

                    b.HasIndex("InstallationId")
                        .IsUnique()
                        .HasDatabaseName("ix_devices_installation_id");

                    b.ToTable("devices", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Household", b =>
                {
                    b.Property<long>("HouseholdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("household_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("HouseholdId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint")
                        .HasColumnName("owner_id");

                    b.Property<int>("SubscriptionType")
                        .HasColumnType("integer")
                        .HasColumnName("subscription_type");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("HouseholdId")
                        .HasName("pk_households");

                    b.ToTable("households", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Invitation", b =>
                {
                    b.Property<long>("InvitationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("invitation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("InvitationId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<long>("CreatorId")
                        .HasColumnType("bigint")
                        .HasColumnName("creator_id");

                    b.Property<Guid>("FriendsCode")
                        .HasColumnType("uuid")
                        .HasColumnName("friends_code");

                    b.Property<long>("HouseholdId")
                        .HasColumnType("bigint")
                        .HasColumnName("household_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<DateTime>("ValidUntilDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("valid_until_date");

                    b.HasKey("InvitationId")
                        .HasName("pk_invitations");

                    b.HasIndex("CreatorId")
                        .HasDatabaseName("ix_invitations_creator_id");

                    b.HasIndex("FriendsCode")
                        .HasDatabaseName("ix_invitations_friends_code");

                    b.HasIndex("HouseholdId")
                        .HasDatabaseName("ix_invitations_household_id");

                    b.ToTable("invitations", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Metadata", b =>
                {
                    b.Property<long>("MetadataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("metadata_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("MetadataId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Product>("FoodFacts")
                        .HasColumnType("jsonb")
                        .HasColumnName("food_facts");

                    b.Property<string>("GlobalTradeItemNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("global_trade_item_number");

                    b.Property<NonFoodProduct>("ProductFacts")
                        .HasColumnType("jsonb")
                        .HasColumnName("product_facts");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("MetadataId")
                        .HasName("pk_metadatas");

                    b.HasIndex("GlobalTradeItemNumber")
                        .HasDatabaseName("ix_metadatas_global_trade_item_number");

                    b.ToTable("metadatas", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.StorageLocation", b =>
                {
                    b.Property<long>("StorageLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("storage_location_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("StorageLocationId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<long>("HouseholdId")
                        .HasColumnType("bigint")
                        .HasColumnName("household_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("StorageLocationId")
                        .HasName("pk_storage_locations");

                    b.HasIndex("HouseholdId")
                        .HasDatabaseName("ix_storage_locations_household_id");

                    b.ToTable("storage_locations", (string)null);
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Account", b =>
                {
                    b.HasOne("Pantry.Core.Persistence.Entities.Household", "Household")
                        .WithMany("Accounts")
                        .HasForeignKey("HouseholdId")
                        .HasConstraintName("fk_accounts_households_household_id");

                    b.Navigation("Household");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Article", b =>
                {
                    b.HasOne("Pantry.Core.Persistence.Entities.Household", "Household")
                        .WithMany("Articles")
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_articles_households_household_id");

                    b.HasOne("Pantry.Core.Persistence.Entities.StorageLocation", "StorageLocation")
                        .WithMany("Articles")
                        .HasForeignKey("StorageLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_articles_storage_locations_storage_location_id");

                    b.Navigation("Household");

                    b.Navigation("StorageLocation");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Device", b =>
                {
                    b.HasOne("Pantry.Core.Persistence.Entities.Account", "Account")
                        .WithMany("Devices")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_devices_accounts_account_id");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Invitation", b =>
                {
                    b.HasOne("Pantry.Core.Persistence.Entities.Account", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_invitations_accounts_creator_id");

                    b.HasOne("Pantry.Core.Persistence.Entities.Household", "Household")
                        .WithMany("Invitations")
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_invitations_households_household_id");

                    b.Navigation("Creator");

                    b.Navigation("Household");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.StorageLocation", b =>
                {
                    b.HasOne("Pantry.Core.Persistence.Entities.Household", "Household")
                        .WithMany("StorageLocations")
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_storage_locations_households_household_id");

                    b.Navigation("Household");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Account", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.Household", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Articles");

                    b.Navigation("Invitations");

                    b.Navigation("StorageLocations");
                });

            modelBuilder.Entity("Pantry.Core.Persistence.Entities.StorageLocation", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
