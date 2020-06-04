﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using losol.EventManagement.Infrastructure;

namespace losol.EventManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200604144542_LmsEnrollmentFields")]
    partial class LmsEnrollmentFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<bool>("Archived")
                        .HasColumnType("boolean");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("SignatureImageBase64")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Certificate", b =>
                {
                    b.Property<int>("CertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<Guid>("Auth")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CertificateGuid")
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("EvidenceDescription")
                        .HasColumnType("text");

                    b.Property<string>("IssuedByName")
                        .HasColumnType("text");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IssuedInCity")
                        .HasColumnType("text");

                    b.Property<int?>("IssuingOrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("IssuingOrganizationName")
                        .HasColumnType("text");

                    b.Property<string>("IssuingUserId")
                        .HasColumnType("text");

                    b.Property<string>("RecipientEmail")
                        .HasColumnType("text");

                    b.Property<string>("RecipientName")
                        .HasColumnType("text");

                    b.Property<string>("RecipientUserId")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("StatusComment")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CertificateId");

                    b.HasIndex("IssuingOrganizationId");

                    b.HasIndex("IssuingUserId");

                    b.HasIndex("RecipientUserId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.EventInfo", b =>
                {
                    b.Property<int>("EventInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("CertificateDescription")
                        .HasColumnType("text");

                    b.Property<string>("CertificateTitle")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("ExternalInfoPageUrl")
                        .HasColumnType("text");

                    b.Property<string>("ExternalRegistrationsUrl")
                        .HasColumnType("text");

                    b.Property<bool>("Featured")
                        .HasColumnType("boolean");

                    b.Property<string>("FeaturedImageCaption")
                        .HasColumnType("text");

                    b.Property<string>("FeaturedImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("InformationRequest")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastCancellationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastRegistrationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LmsCourseId")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<bool>("ManageRegistrations")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("integer");

                    b.Property<string>("MoreInformation")
                        .HasColumnType("text");

                    b.Property<bool>("OnDemand")
                        .HasColumnType("boolean");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("OrganizerUserId")
                        .HasColumnType("text");

                    b.Property<string>("PracticalInformation")
                        .HasColumnType("text");

                    b.Property<string>("Program")
                        .HasColumnType("text");

                    b.Property<string>("ProjectCode")
                        .HasColumnType("text");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("WelcomeLetter")
                        .HasColumnType("text");

                    b.HasKey("EventInfoId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("OrganizerUserId");

                    b.ToTable("EventInfos");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.MessageLog", b =>
                {
                    b.Property<int>("MessageLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EventInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("MessageContent")
                        .HasColumnType("text");

                    b.Property<string>("MessageType")
                        .HasColumnType("text");

                    b.Property<string>("Provider")
                        .HasColumnType("text");

                    b.Property<string>("Recipients")
                        .HasColumnType("text");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("MessageLogId");

                    b.HasIndex("EventInfoId");

                    b.ToTable("MessageLogs");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("text");

                    b.Property<string>("CustomerInvoiceReference")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .HasColumnType("text");

                    b.Property<string>("CustomerVatNumber")
                        .HasColumnType("text");

                    b.Property<string>("ExternalInvoiceId")
                        .HasColumnType("text");

                    b.Property<string>("Log")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Paid")
                        .HasColumnType("boolean");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("integer");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("OrderId");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.OrderLine", b =>
                {
                    b.Property<int>("OrderLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("text");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<string>("ProductVariantDescription")
                        .HasColumnType("text");

                    b.Property<int?>("ProductVariantId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductVariantName")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int?>("RefundOrderId")
                        .HasColumnType("integer");

                    b.Property<int?>("RefundOrderLineId")
                        .HasColumnType("integer");

                    b.Property<decimal>("VatPercent")
                        .HasColumnType("numeric");

                    b.HasKey("OrderLineId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductVariantId");

                    b.HasIndex("RefundOrderId");

                    b.HasIndex("RefundOrderLineId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Email")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("LogoBase64")
                        .HasColumnType("text");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Url")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<string>("VatId")
                        .HasColumnType("text");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.PaymentMethod", b =>
                {
                    b.Property<int>("Provider")
                        .HasColumnType("integer");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<bool>("AdminOnly")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Provider");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("integer");

                    b.Property<bool>("EnableQuantity")
                        .HasColumnType("boolean");

                    b.Property<int>("EventInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("Inventory")
                        .HasColumnType("integer");

                    b.Property<int>("MinimumQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("MoreInformation")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean");

                    b.Property<int>("VatPercent")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.HasIndex("EventInfoId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.ProductVariant", b =>
                {
                    b.Property<int>("ProductVariantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AdminOnly")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Inventory")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean");

                    b.Property<int>("VatPercent")
                        .HasColumnType("integer");

                    b.HasKey("ProductVariantId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductVariants");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CertificateComment")
                        .HasColumnType("text");

                    b.Property<int?>("CertificateId")
                        .HasColumnType("integer");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("text");

                    b.Property<string>("CustomerCity")
                        .HasColumnType("text");

                    b.Property<string>("CustomerCountry")
                        .HasColumnType("text");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("text");

                    b.Property<string>("CustomerInvoiceReference")
                        .HasColumnType("text");

                    b.Property<string>("CustomerName")
                        .HasColumnType("text");

                    b.Property<string>("CustomerVatNumber")
                        .HasColumnType("text");

                    b.Property<string>("CustomerZip")
                        .HasColumnType("text");

                    b.Property<bool>("Diploma")
                        .HasColumnType("boolean");

                    b.Property<bool>("EnrolledInLms")
                        .HasColumnType("boolean");

                    b.Property<int>("EventInfoId")
                        .HasColumnType("integer");

                    b.Property<bool>("FreeRegistration")
                        .HasColumnType("boolean");

                    b.Property<string>("Log")
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("ParticipantCity")
                        .HasColumnType("text");

                    b.Property<string>("ParticipantEmployer")
                        .HasColumnType("text");

                    b.Property<string>("ParticipantJobTitle")
                        .HasColumnType("text");

                    b.Property<string>("ParticipantName")
                        .HasColumnType("text");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("integer");

                    b.Property<string>("RegistrationBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RegistrationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("text");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("EventInfoId");

                    b.HasIndex("UserId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Certificate", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Organization", "IssuingOrganization")
                        .WithMany()
                        .HasForeignKey("IssuingOrganizationId");

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", "IssuingUser")
                        .WithMany()
                        .HasForeignKey("IssuingUserId");

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", "RecipientUser")
                        .WithMany()
                        .HasForeignKey("RecipientUserId");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.EventInfo", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", "OrganizerUser")
                        .WithMany()
                        .HasForeignKey("OrganizerUserId");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.MessageLog", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.EventInfo", "EventInfo")
                        .WithMany()
                        .HasForeignKey("EventInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Order", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Registration", "Registration")
                        .WithMany("Orders")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.OrderLine", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("losol.EventManagement.Domain.Product", "Product")
                        .WithMany("OrderLines")
                        .HasForeignKey("ProductId");

                    b.HasOne("losol.EventManagement.Domain.ProductVariant", "ProductVariant")
                        .WithMany("OrderLines")
                        .HasForeignKey("ProductVariantId");

                    b.HasOne("losol.EventManagement.Domain.Order", "RefundOrder")
                        .WithMany()
                        .HasForeignKey("RefundOrderId");

                    b.HasOne("losol.EventManagement.Domain.OrderLine", "RefundOrderLine")
                        .WithMany()
                        .HasForeignKey("RefundOrderLineId");
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Product", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.EventInfo", "Eventinfo")
                        .WithMany("Products")
                        .HasForeignKey("EventInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("losol.EventManagement.Domain.ProductVariant", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Product", "Product")
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("losol.EventManagement.Domain.Registration", b =>
                {
                    b.HasOne("losol.EventManagement.Domain.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");

                    b.HasOne("losol.EventManagement.Domain.EventInfo", "EventInfo")
                        .WithMany("Registrations")
                        .HasForeignKey("EventInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("losol.EventManagement.Domain.ApplicationUser", "User")
                        .WithMany("Registrations")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
