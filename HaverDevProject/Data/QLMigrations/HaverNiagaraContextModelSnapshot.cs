﻿// <auto-generated />
using System;
using HaverDevProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HaverDevProject.Data.QLMigrations
{
    [DbContext(typeof(HaverNiagaraContext))]
    partial class HaverNiagaraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("HaverDevProject.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("carId");

                    b.Property<int>("CarNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("carNumber");

                    b.Property<int>("NcrPurchId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("defectId");

                    b.Property<string>("DefectDesription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("defectDesription");

                    b.Property<string>("DefectName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("defectName");

                    b.HasKey("DefectId")
                        .HasName("pk_defect_defectId");

                    b.ToTable("defect");
                });

            modelBuilder.Entity("HaverDevProject.Models.Drawing", b =>
                {
                    b.Property<int>("DrawingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("drawingId");

                    b.Property<int>("DrawingOriginalRevNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("drawingOriginalRevNumber");

                    b.Property<DateTime>("DrawingRevDate")
                        .HasColumnType("date")
                        .HasColumnName("drawingRevDate");

                    b.Property<int>("DrawingUpdatedRevNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("drawingUpdatedRevNumber");

                    b.Property<int>("DrawingUserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("drawingUserId");

                    b.Property<int>("NcrEngId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("engDispositionTypeId");

                    b.Property<string>("EngDispositionTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("engDispositionTypeName");

                    b.HasKey("EngDispositionTypeId")
                        .HasName("pk_engDispoistionType_engDispositionTypeId");

                    b.ToTable("engDispositionType");
                });

            modelBuilder.Entity("HaverDevProject.Models.FollowUp", b =>
                {
                    b.Property<int>("FollowUpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("followUpId");

                    b.Property<DateTime>("FollowUpExpectedDate")
                        .HasColumnType("date")
                        .HasColumnName("followUpExpectedDate");

                    b.Property<int>("FollowUpTypeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("followUpTypeId");

                    b.Property<int>("NcrPurchId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("followUpTypeId");

                    b.Property<string>("FollowUpTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("followUpTypeName");

                    b.HasKey("FollowUpTypeId")
                        .HasName("pk_followUpType_followUpTypeId");

                    b.ToTable("followUpType");
                });

            modelBuilder.Entity("HaverDevProject.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemId");

                    b.Property<string>("ItemDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("itemDescription");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("itemName");

                    b.Property<int>("ItemNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemNumber");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("supplierId");

                    b.HasKey("ItemId")
                        .HasName("pk_item_itemId");

                    b.HasIndex("ItemNumber")
                        .IsUnique();

                    b.HasIndex("SupplierId");

                    b.ToTable("item");
                });

            modelBuilder.Entity("HaverDevProject.Models.ItemDefect", b =>
                {
                    b.Property<int>("ItemDefectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemDefectId");

                    b.Property<int>("DefectId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("defectId");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemDefectPhotoId");

                    b.Property<int>("ItemDefectId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemDefectId");

                    b.Property<byte[]>("ItemDefectPhotoContent")
                        .IsRequired()
                        .HasColumnType("BLOB")
                        .HasColumnName("itemDefectPhotoContent");

                    b.Property<string>("ItemDefectPhotoDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("itemDefectPhotoDescription");

                    b.Property<string>("ItemDefectPhotoMimeType")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemDefectVideoId");

                    b.Property<int>("ItemDefectId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemDefectId");

                    b.Property<string>("ItemDefectVideoLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrId");

                    b.Property<DateTime>("NcrLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrLastUpdated");

                    b.Property<string>("NcrNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("ncrNumber");

                    b.Property<int>("StatusUpdateId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrEngId");

                    b.Property<int>("EngDispositionTypeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("engDispositionTypeId");

                    b.Property<DateTime>("NcrEngCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrEngCreationDate");

                    b.Property<bool?>("NcrEngCustomerNotification")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrEngCustomerNotification");

                    b.Property<string>("NcrEngDispositionDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("ncrEngDispositionDescription");

                    b.Property<DateTime>("NcrEngLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrEngLastUpdated");

                    b.Property<int>("NcrEngUserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrEngUserId");

                    b.Property<int>("NcrId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrPurchId");

                    b.Property<int>("NcrId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrId");

                    b.Property<DateTime>("NcrPurchCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrPurchCreationDate");

                    b.Property<string>("NcrPurchasingDescription")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("ncrPurchasingDescription");

                    b.Property<DateTime>("NcrPurchasingLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrPurchasingLastUpdated");

                    b.Property<int>("NcrPurchasingUserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrPurchasingUserId");

                    b.Property<int>("OpDispositionTypeId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrQAId");

                    b.Property<int>("NcrId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrId");

                    b.Property<DateTime>("NcrQacreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrQACreationDate");

                    b.Property<bool>("NcrQaitemMarNonConforming")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrQAItemMarNonConforming");

                    b.Property<DateTime>("NcrQalastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrQALastUpdated");

                    b.Property<string>("NcrQasalesOrder")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("ncrQASalesOrder");

                    b.Property<int>("NcrQauserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrQAUserId");

                    b.Property<int>("ProAppId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrReInspectId");

                    b.Property<int>("NcrId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrId");

                    b.Property<bool>("NcrReInspectAcceptable")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrReInspectAcceptable");

                    b.Property<DateTime>("NcrReInspectCreationDate")
                        .HasColumnType("date")
                        .HasColumnName("ncrReInspectCreationDate");

                    b.Property<DateTime>("NcrReInspectLastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("ncrReInspectLastUpdated");

                    b.Property<int?>("NcrReInspectNewNcrNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrReInspectNewNcrNumber");

                    b.Property<int>("NcrReInspectUserId")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("opDispositionTypeId");

                    b.Property<string>("OpDispositionTypeName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("opDispositionTypeName");

                    b.HasKey("OpDispositionTypeId")
                        .HasName("pk_opDispositionType_opDispositionTypeId");

                    b.ToTable("opDispositionType");
                });

            modelBuilder.Entity("HaverDevProject.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("orderId");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("itemId");

                    b.Property<int>("NcrQaid")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ncrQAId");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER")
                        .HasColumnName("orderNumber");

                    b.Property<int>("OrderQuanDefective")
                        .HasColumnType("INTEGER")
                        .HasColumnName("orderQuanDefective");

                    b.Property<int>("OrderQuanReceived")
                        .HasColumnType("INTEGER")
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
                        .HasColumnType("INTEGER")
                        .HasColumnName("proAppId");

                    b.Property<string>("ProAppName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("proAppName");

                    b.HasKey("ProAppId")
                        .HasName("pk_processApplicable_proAppId");

                    b.ToTable("processApplicable");
                });

            modelBuilder.Entity("HaverDevProject.Models.StatusUpdate", b =>
                {
                    b.Property<int>("StatusUpdateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("statusUpdateId");

                    b.Property<string>("StatusUpdateName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("statusUpdateName");

                    b.HasKey("StatusUpdateId")
                        .HasName("pk_status_statusUpdateId");

                    b.ToTable("statusUpdate");
                });

            modelBuilder.Entity("HaverDevProject.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("supplierId");

                    b.Property<string>("SupplierCode")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("supplierCode");

                    b.Property<string>("SupplierEmail")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("supplierEmail");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("TEXT")
                        .HasColumnName("supplierName");

                    b.HasKey("SupplierId")
                        .HasName("pk_supplier_supplierId");

                    b.HasIndex("SupplierCode")
                        .IsUnique();

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
