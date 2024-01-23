﻿// <auto-generated />
using System;
using HaverDevProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HaverDevProject.Data.HNMigrations
{
    [DbContext(typeof(HaverNiagaraContext))]
    [Migration("20240123032836_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HaverDevProject.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("carId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<int>("CarNumber")
                        .HasColumnType("int")
                        .HasColumnName("carNumber");

                    b.Property<int>("NcrPurchId")
                        .HasColumnType("int")
                        .HasColumnName("ncrPurchId");

                    b.HasKey("CarId")
                        .HasName("pk_car_carId");

                    b.HasIndex("NcrPurchId");

                    b.ToTable("car");
                });

            modelBuilder.Entity("HaverDevProject.Models.Defect", b =>
                {
                    b.Property<int>("DefectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("defectId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DefectId"));

                    b.Property<string>("DefectDesription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("defectDesription");

                    b.Property<string>("DefectName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("defectName");

                    b.HasKey("DefectId")
                        .HasName("pk_defect_defectId");

                    b.ToTable("defect");
                });

            modelBuilder.Entity("HaverDevProject.Models.Drawing", b =>
                {
                    b.Property<int>("DrawingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("drawingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrawingId"));

                    b.Property<int>("DrawingOriginalRevNumber")
                        .HasColumnType("int")
                        .HasColumnName("drawingOriginalRevNumber");

                    b.Property<DateTime>("DrawingRevDate")
                        .HasColumnType("date")
                        .HasColumnName("drawingRevDate");

                    b.Property<int>("DrawingUpdatedRevNumber")
                        .HasColumnType("int")
                        .HasColumnName("drawingUpdatedRevNumber");

                    b.Property<int>("DrawingUserId")
                        .HasColumnType("int")
                        .HasColumnName("drawingUserId");

                    b.Property<int>("NcrEngId")
                        .HasColumnType("int")
                        .HasColumnName("ncrEngId");

                    b.HasKey("DrawingId")
                        .HasName("pk_drawing_drawingId");

                    b.HasIndex("NcrEngId");

                    b.ToTable("drawing");
                });

            modelBuilder.Entity("HaverDevProject.Models.EngDispositionType", b =>
                {
                    b.Property<int>("EngDispositionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("engDispositionTypeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EngDispositionTypeId"));

                    b.Property<string>("EngDispositionTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("engDispositionTypeName");

                    b.HasKey("EngDispositionTypeId")
                        .HasName("pk_engDispoistionType_engDispositionTypeId");

                    b.ToTable("engDispositionType");
                });

            modelBuilder.Entity("HaverDevProject.Models.FollowUp", b =>
                {
                    b.Property<int>("FollowUpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("followUpId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FollowUpId"));

                    b.Property<DateTime>("FollowUpExpectedDate")
                        .HasColumnType("date")
                        .HasColumnName("followUpExpectedDate");

                    b.Property<int>("FollowUpTypeId")
                        .HasColumnType("int")
                        .HasColumnName("followUpTypeId");

                    b.Property<int>("NcrPurchId")
                        .HasColumnType("int")
                        .HasColumnName("ncrPurchId");

                    b.HasKey("FollowUpId")
                        .HasName("pk_followUp_followUpId");

                    b.HasIndex("FollowUpTypeId");

                    b.HasIndex("NcrPurchId");

                    b.ToTable("followUp");
                });

            modelBuilder.Entity("HaverDevProject.Models.FollowUpType", b =>
                {
                    b.Property<int>("FollowUpTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("followUpTypeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FollowUpTypeId"));

                    b.Property<string>("FollowUpTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("followUpTypeName");

                    b.HasKey("FollowUpTypeId")
                        .HasName("pk_followUpType_followUpTypeId");

                    b.ToTable("followUpType");
                });

            modelBuilder.Entity("HaverDevProject.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("itemId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("ItemDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("itemDescription");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("itemName");

                    b.Property<int>("ItemNumber")
                        .HasColumnType("int")
                        .HasColumnName("itemNumber");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplierId");

                    b.HasKey("ItemId")
                        .HasName("pk_item_itemId");

                    b.HasIndex("SupplierId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefect", b =>
                {
                    b.Property<int>("ItemDefectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("itemDefectId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemDefectId"));

                    b.Property<int>("DefectId")
                        .HasColumnType("int")
                        .HasColumnName("defectId");

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("itemId");

                    b.HasKey("ItemDefectId")
                        .HasName("pk_itemDefect_itemDefectId");

                    b.HasIndex("DefectId");

                    b.HasIndex("ItemId");

                    b.ToTable("itemDefect");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefectPhoto", b =>
                {
                    b.Property<int>("ItemDefectPhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("itemDefectPhotoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemDefectPhotoId"));

                    b.Property<int>("ItemDefectId")
                        .HasColumnType("int")
                        .HasColumnName("itemDefectId");

                    b.Property<byte[]>("ItemDefectPhotoContent")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("itemDefectPhotoContent");

                    b.Property<string>("ItemDefectPhotoDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("itemDefectPhotoDescription");

                    b.Property<string>("ItemDefectPhotoMimeType")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("itemDefectPhotoMimeType");

                    b.HasKey("ItemDefectPhotoId")
                        .HasName("pk_itemDefectPhoto_itemDefectPhotoId");

                    b.HasIndex("ItemDefectId");

                    b.ToTable("itemDefectPhoto");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefectVideo", b =>
                {
                    b.Property<int>("ItemDefectVideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("itemDefectVideoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemDefectVideoId"));

                    b.Property<int>("ItemDefectId")
                        .HasColumnType("int")
                        .HasColumnName("itemDefectId");

                    b.Property<string>("ItemDefectVideoLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("itemDefectVideoLink");

                    b.HasKey("ItemDefectVideoId")
                        .HasName("pk_itemDefectVideo");

                    b.HasIndex("ItemDefectId");

                    b.ToTable("itemDefectVideo");
                });

            modelBuilder.Entity("HaverDevProject.Models.Ncr", b =>
                {
                    b.Property<int>("NcrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ncrId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NcrId"));

                    b.Property<DateTime>("NcrLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrLastUpdated");

                    b.Property<string>("NcrNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ncrNumber");

                    b.Property<int>("StatusUpdateId")
                        .HasColumnType("int")
                        .HasColumnName("statusUpdateId");

                    b.HasKey("NcrId")
                        .HasName("pk_ncr_ncrId");

                    b.HasIndex("StatusUpdateId");

                    b.ToTable("ncr");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrEng", b =>
                {
                    b.Property<int>("NcrEngId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ncrEngId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NcrEngId"));

                    b.Property<int>("EngDispositionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("engDispositionTypeId");

                    b.Property<DateTime>("NcrEngCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrEngCreationDate");

                    b.Property<bool?>("NcrEngCustomerNotification")
                        .HasColumnType("bit")
                        .HasColumnName("ncrEngCustomerNotification");

                    b.Property<string>("NcrEngDispositionDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("ncrEngDispositionDescription");

                    b.Property<DateTime>("NcrEngLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrEngLastUpdated");

                    b.Property<int>("NcrEngUserId")
                        .HasColumnType("int")
                        .HasColumnName("ncrEngUserId");

                    b.Property<int>("NcrId")
                        .HasColumnType("int")
                        .HasColumnName("ncrId");

                    b.HasKey("NcrEngId")
                        .HasName("pk_ncrEng_ncrEngId");

                    b.HasIndex("EngDispositionTypeId");

                    b.HasIndex("NcrId");

                    b.ToTable("ncrEng");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrPurchasing", b =>
                {
                    b.Property<int>("NcrPurchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ncrPurchId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NcrPurchId"));

                    b.Property<int>("NcrId")
                        .HasColumnType("int")
                        .HasColumnName("ncrId");

                    b.Property<DateTime>("NcrPurchCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrPurchCreationDate");

                    b.Property<DateTime>("NcrPurchasingLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrPurchasingLastUpdated");

                    b.Property<int>("NcrPurchasingUserId")
                        .HasColumnType("int")
                        .HasColumnName("ncrPurchasingUserId");

                    b.Property<int>("OpDispositionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("opDispositionTypeId");

                    b.HasKey("NcrPurchId")
                        .HasName("pk_ncrPurchasing_ncrPurchId");

                    b.HasIndex("NcrId");

                    b.HasIndex("OpDispositionTypeId");

                    b.ToTable("ncrPurchasing");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrQa", b =>
                {
                    b.Property<int>("NcrQaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ncrQAId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NcrQaid"));

                    b.Property<int>("NcrId")
                        .HasColumnType("int")
                        .HasColumnName("ncrId");

                    b.Property<DateTime>("NcrQacreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrQACreationDate");

                    b.Property<bool>("NcrQaitemMarNonConforming")
                        .HasColumnType("bit")
                        .HasColumnName("ncrQAItemMarNonConforming");

                    b.Property<DateTime>("NcrQalastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrQALastUpdated");

                    b.Property<string>("NcrQasalesOrder")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("ncrQASalesOrder");

                    b.Property<int>("NcrQauserId")
                        .HasColumnType("int")
                        .HasColumnName("ncrQAUserId");

                    b.Property<int>("ProAppId")
                        .HasColumnType("int")
                        .HasColumnName("proAppId");

                    b.HasKey("NcrQaid")
                        .HasName("pk_ncrQA_ncrQAId");

                    b.HasIndex("NcrId");

                    b.HasIndex("ProAppId");

                    b.ToTable("ncrQA");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrReInspect", b =>
                {
                    b.Property<int>("NcrReInspectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ncrReInspectId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NcrReInspectId"));

                    b.Property<int>("NcrId")
                        .HasColumnType("int")
                        .HasColumnName("ncrId");

                    b.Property<bool>("NcrReInspectAcceptable")
                        .HasColumnType("bit")
                        .HasColumnName("ncrReInspectAcceptable");

                    b.Property<DateTime>("NcrReInspectCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrReInspectCreationDate");

                    b.Property<DateTime>("NcrReInspectLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrReInspectLastUpdated");

                    b.Property<int?>("NcrReInspectNewNcrNumber")
                        .HasColumnType("int")
                        .HasColumnName("ncrReInspectNewNcrNumber");

                    b.Property<int>("NcrReInspectUserId")
                        .HasColumnType("int")
                        .HasColumnName("ncrReInspectUserId");

                    b.HasKey("NcrReInspectId")
                        .HasName("pk_ncrReInspect_ncrReInspectId");

                    b.HasIndex("NcrId");

                    b.ToTable("ncrReInspect");
                });

            modelBuilder.Entity("HaverDevProject.Models.OpDispositionType", b =>
                {
                    b.Property<int>("OpDispositionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("opDispositionTypeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OpDispositionTypeId"));

                    b.Property<string>("OpDispositionTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("opDispositionTypeName");

                    b.HasKey("OpDispositionTypeId")
                        .HasName("pk_opDispositionType_opDispositionTypeId");

                    b.ToTable("opDispositionType");
                });

            modelBuilder.Entity("HaverDevProject.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("orderId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int")
                        .HasColumnName("itemId");

                    b.Property<int>("NcrQaid")
                        .HasColumnType("int")
                        .HasColumnName("ncrQAId");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int")
                        .HasColumnName("orderNumber");

                    b.Property<int>("OrderQuanDefective")
                        .HasColumnType("int")
                        .HasColumnName("orderQuanDefective");

                    b.Property<int>("OrderQuanReceived")
                        .HasColumnType("int")
                        .HasColumnName("orderQuanReceived");

                    b.HasKey("OrderId")
                        .HasName("pk_orderDetail_orderId");

                    b.HasIndex("ItemId");

                    b.HasIndex("NcrQaid");

                    b.ToTable("orderDetail");
                });

            modelBuilder.Entity("HaverDevProject.Models.ProcessApplicable", b =>
                {
                    b.Property<int>("ProAppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("proAppId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProAppId"));

                    b.Property<string>("ProAppName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("proAppName");

                    b.HasKey("ProAppId")
                        .HasName("pk_processApplicable_proAppId");

                    b.ToTable("processApplicable");
                });

            modelBuilder.Entity("HaverDevProject.Models.StatusUpdate", b =>
                {
                    b.Property<int>("StatusUpdateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("statusUpdateId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusUpdateId"));

                    b.Property<string>("StatusUpdateName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("statusUpdateName");

                    b.HasKey("StatusUpdateId")
                        .HasName("pk_status_statusUpdateId");

                    b.ToTable("statusUpdate");
                });

            modelBuilder.Entity("HaverDevProject.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("supplierId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("SupplierCode")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("supplierCode");

                    b.Property<string>("SupplierEmail")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("supplierEmail");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("supplierName");

                    b.HasKey("SupplierId")
                        .HasName("pk_supplier_supplierId");

                    b.ToTable("supplier");
                });

            modelBuilder.Entity("HaverDevProject.Models.Car", b =>
                {
                    b.HasOne("HaverDevProject.Models.NcrPurchasing", "NcrPurch")
                        .WithMany("Cars")
                        .HasForeignKey("NcrPurchId")
                        .IsRequired()
                        .HasConstraintName("fk_car_ncrPurchasing");

                    b.Navigation("NcrPurch");
                });

            modelBuilder.Entity("HaverDevProject.Models.Drawing", b =>
                {
                    b.HasOne("HaverDevProject.Models.NcrEng", "NcrEng")
                        .WithMany("Drawings")
                        .HasForeignKey("NcrEngId")
                        .IsRequired()
                        .HasConstraintName("fk_drawing_ncrEng");

                    b.Navigation("NcrEng");
                });

            modelBuilder.Entity("HaverDevProject.Models.FollowUp", b =>
                {
                    b.HasOne("HaverDevProject.Models.FollowUpType", "FollowUpType")
                        .WithMany("FollowUps")
                        .HasForeignKey("FollowUpTypeId")
                        .IsRequired()
                        .HasConstraintName("fk_followUp_followUpType");

                    b.HasOne("HaverDevProject.Models.NcrPurchasing", "NcrPurch")
                        .WithMany("FollowUps")
                        .HasForeignKey("NcrPurchId")
                        .IsRequired()
                        .HasConstraintName("fk_followUp_ncrPurchasing");

                    b.Navigation("FollowUpType");

                    b.Navigation("NcrPurch");
                });

            modelBuilder.Entity("HaverDevProject.Models.Item", b =>
                {
                    b.HasOne("HaverDevProject.Models.Supplier", "Supplier")
                        .WithMany("Items")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("fk_item_supplier");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefect", b =>
                {
                    b.HasOne("HaverDevProject.Models.Defect", "Defect")
                        .WithMany("ItemDefects")
                        .HasForeignKey("DefectId")
                        .IsRequired()
                        .HasConstraintName("fk_itemDefect_defect");

                    b.HasOne("HaverDevProject.Models.Item", "Item")
                        .WithMany("ItemDefects")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("fk_itemDefect_item");

                    b.Navigation("Defect");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefectPhoto", b =>
                {
                    b.HasOne("HaverDevProject.Models.ItemDefect", "ItemDefect")
                        .WithMany("ItemDefectPhotos")
                        .HasForeignKey("ItemDefectId")
                        .IsRequired()
                        .HasConstraintName("fk_itemDefectPhoto_itemDefect");

                    b.Navigation("ItemDefect");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefectVideo", b =>
                {
                    b.HasOne("HaverDevProject.Models.ItemDefect", "ItemDefect")
                        .WithMany("ItemDefectVideos")
                        .HasForeignKey("ItemDefectId")
                        .IsRequired()
                        .HasConstraintName("fk_itemDefectVideo_itemDefect");

                    b.Navigation("ItemDefect");
                });

            modelBuilder.Entity("HaverDevProject.Models.Ncr", b =>
                {
                    b.HasOne("HaverDevProject.Models.StatusUpdate", "StatusUpdate")
                        .WithMany("Ncrs")
                        .HasForeignKey("StatusUpdateId")
                        .IsRequired()
                        .HasConstraintName("fk_ncr_statusUpdate");

                    b.Navigation("StatusUpdate");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrEng", b =>
                {
                    b.HasOne("HaverDevProject.Models.EngDispositionType", "EngDispositionType")
                        .WithMany("NcrEngs")
                        .HasForeignKey("EngDispositionTypeId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrEng_engDispositionType");

                    b.HasOne("HaverDevProject.Models.Ncr", "Ncr")
                        .WithMany("NcrEngs")
                        .HasForeignKey("NcrId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrEng_ncr");

                    b.Navigation("EngDispositionType");

                    b.Navigation("Ncr");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrPurchasing", b =>
                {
                    b.HasOne("HaverDevProject.Models.Ncr", "Ncr")
                        .WithMany("NcrPurchasings")
                        .HasForeignKey("NcrId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrPurchasing_ncr");

                    b.HasOne("HaverDevProject.Models.OpDispositionType", "OpDispositionType")
                        .WithMany("NcrPurchasings")
                        .HasForeignKey("OpDispositionTypeId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrPurchasing_opDispositionType");

                    b.Navigation("Ncr");

                    b.Navigation("OpDispositionType");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrQa", b =>
                {
                    b.HasOne("HaverDevProject.Models.Ncr", "Ncr")
                        .WithMany("NcrQas")
                        .HasForeignKey("NcrId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrQA_ncr");

                    b.HasOne("HaverDevProject.Models.ProcessApplicable", "ProApp")
                        .WithMany("NcrQas")
                        .HasForeignKey("ProAppId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrQA_processApplicable");

                    b.Navigation("Ncr");

                    b.Navigation("ProApp");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrReInspect", b =>
                {
                    b.HasOne("HaverDevProject.Models.Ncr", "Ncr")
                        .WithMany("NcrReInspects")
                        .HasForeignKey("NcrId")
                        .IsRequired()
                        .HasConstraintName("fk_ncrReInspect_ncr");

                    b.Navigation("Ncr");
                });

            modelBuilder.Entity("HaverDevProject.Models.OrderDetail", b =>
                {
                    b.HasOne("HaverDevProject.Models.Item", "Item")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ItemId")
                        .IsRequired()
                        .HasConstraintName("fk_orderDetail_item");

                    b.HasOne("HaverDevProject.Models.NcrQa", "NcrQa")
                        .WithMany("OrderDetails")
                        .HasForeignKey("NcrQaid")
                        .IsRequired()
                        .HasConstraintName("fk_orderDetail_ncrQA");

                    b.Navigation("Item");

                    b.Navigation("NcrQa");
                });

            modelBuilder.Entity("HaverDevProject.Models.Defect", b =>
                {
                    b.Navigation("ItemDefects");
                });

            modelBuilder.Entity("HaverDevProject.Models.EngDispositionType", b =>
                {
                    b.Navigation("NcrEngs");
                });

            modelBuilder.Entity("HaverDevProject.Models.FollowUpType", b =>
                {
                    b.Navigation("FollowUps");
                });

            modelBuilder.Entity("HaverDevProject.Models.Item", b =>
                {
                    b.Navigation("ItemDefects");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefect", b =>
                {
                    b.Navigation("ItemDefectPhotos");

                    b.Navigation("ItemDefectVideos");
                });

            modelBuilder.Entity("HaverDevProject.Models.Ncr", b =>
                {
                    b.Navigation("NcrEngs");

                    b.Navigation("NcrPurchasings");

                    b.Navigation("NcrQas");

                    b.Navigation("NcrReInspects");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrEng", b =>
                {
                    b.Navigation("Drawings");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrPurchasing", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("FollowUps");
                });

            modelBuilder.Entity("HaverDevProject.Models.NcrQa", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("HaverDevProject.Models.OpDispositionType", b =>
                {
                    b.Navigation("NcrPurchasings");
                });

            modelBuilder.Entity("HaverDevProject.Models.ProcessApplicable", b =>
                {
                    b.Navigation("NcrQas");
                });

            modelBuilder.Entity("HaverDevProject.Models.StatusUpdate", b =>
                {
                    b.Navigation("Ncrs");
                });

            modelBuilder.Entity("HaverDevProject.Models.Supplier", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}