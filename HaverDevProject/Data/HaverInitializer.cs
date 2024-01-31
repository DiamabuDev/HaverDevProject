﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using HaverDevProject.Models;
using NuGet.DependencyResolver;
using Microsoft.CodeAnalysis;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System;

namespace HaverDevProject.Data
{
    public static class HaverInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            HaverNiagaraContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<HaverNiagaraContext>();

            try
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                //context.Database.Migrate();


                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(
                        new Supplier
                        {
                            SupplierCode = "793254",
                            SupplierName = "INTEGRITY WOVEN WIRE",
                            SupplierEmail = "integritywire@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "792356",
                            SupplierName = "FLO COMPONENTS LTD.",
                            SupplierEmail = "flocompltd@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700009",
                            SupplierName = "AJAX TOCCO",
                            SupplierEmail = "ajaxtocco@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700013",
                            SupplierName = "HINGSTON METAL FABRICATORS",
                            SupplierEmail = "hingstonmetal@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700027",
                            SupplierName = "HOTZ ENVIRONMENTAL SERVICES",
                            SupplierEmail = "hotzservices@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700044",
                            SupplierName = "BLACK CREEK METAL",
                            SupplierEmail = "blackcreekmetal@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700045",
                            SupplierName = "POLYMER EXTRUSIONS INC",
                            SupplierEmail = "lsm@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700087",
                            SupplierName = "DON CASSELMAN & SON LTD",
                            SupplierEmail = "fastenal@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "880006",
                            SupplierName = "W S TYLER - PARTICLE & FINE",
                            SupplierEmail = "wstyler@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "790891",
                            SupplierName = "LAWRENCE SINTERED METALS",
                            SupplierEmail = "lsm@example.com"
                        },
                        new Supplier
                        {
                            SupplierCode = "700493",
                            SupplierName = "FASTENAL COMPANY",
                            SupplierEmail = "fastenal@example.com"
                        },

                        new Supplier
                        {
                            SupplierCode = "880065",
                            SupplierName = "HBC ENGINEERING",
                            SupplierEmail = "hbc@example.com"
                        });

                    context.SaveChanges();
                }

                if (!context.Items.Any())
                {
                    context.Items.AddRange(
                        new Item
                        {
                            ItemNumber = 10342455,
                            ItemName = "Bearing Housing",
                            ItemDescription = "Protective enclosure for bearings.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "INTEGRITY WOVEN WIRE").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10482834,
                            ItemName = "Backing Shield",
                            ItemDescription = "Shield for internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "FLO COMPONENTS LTD.").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11536261,
                            ItemName = "Side Arm",
                            ItemDescription = "Structural component for reinforcement.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "AJAX TOCCO").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11854290,
                            ItemName = "Panel",
                            ItemDescription = "Surface to house internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "HINGSTON METAL FABRICATORS").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10344215,
                            ItemName = "Bearing Housing",
                            ItemDescription = "Protective enclosure for bearings.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "HOTZ ENVIRONMENTAL SERVICES").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10482863,
                            ItemName = "Backing Shield",
                            ItemDescription = "Shield for internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "BLACK CREEK METAL").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11536287,
                            ItemName = "Side Arm",
                            ItemDescription = "Structural component for reinforcement.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "POLYMER EXTRUSIONS INC").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11854266,
                            ItemName = "Panel",
                            ItemDescription = "Surface to house internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "DON CASSELMAN & SON LTD").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10344216,
                            ItemName = "Bearing Housing",
                            ItemDescription = "Protective enclosure for bearings.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "W S TYLER - PARTICLE & FINE").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10482864,
                            ItemName = "Backing Shield",
                            ItemDescription = "Shield for internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "LAWRENCE SINTERED METALS").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11536288,
                            ItemName = "Side Arm",
                            ItemDescription = "Structural component for reinforcement.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "FASTENAL COMPANY").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11854267,
                            ItemName = "Panel",
                            ItemDescription = "Surface to house internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "HBC ENGINEERING").SupplierId
                        });

                    context.SaveChanges();
                }

                if (!context.Defects.Any())
                {
                    context.Defects.AddRange(

//                        Design Error(Drawing)
//Holes not tapped
//Incorrect dimensions
//Incorrect hardware
//Incorrect hole(size, locations, missing)
//Incorrect thread size
//Not Painted
//Poor Paint finish
//Poor quality surface finish
//Poor Weld quality
//Incorrect fit
//Incorrect weld size
//Missing Items
//Broken / Twisted Wires
//Out of Crimp
//Incorrect Specification
//Incorrect Hook / Hook Orientation
//Incorrect Center Hole Punching
//Missing Center Hole Punching
//Incorrect hardware installation
//Incorrect labelling
//Drawing not updated
//Incorrect material
//Delivery Quality
//Finishing error(M.W.STC)
//Incorrect component(FMP package)


                        new Defect
                        {
                            DefectName = "Incorrect hardware",
                            DefectDesription = "Incorrect hardware was delivered."
                        },
                        new Defect
                        {
                            DefectName = "Delivery quality",
                            DefectDesription = "Quality of hardware was poor."
                        },
                        new Defect
                        {
                            DefectName = "Incorrect specification",
                            DefectDesription = "Hardware did match the specifications."
                        },
                        new Defect
                        {
                            DefectName = "Incorrect dimensions",
                            DefectDesription = "Hardware has improper dimensions."
                        });

                    context.SaveChanges();
                }

                if (!context.ItemDefects.Any())
                {
                    context.ItemDefects.AddRange(
                        new ItemDefect
                        {
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Bearing Housing").ItemId,
                            DefectId = context.Defects.FirstOrDefault(f => f.DefectName == "Delivery quality").DefectId
                        },
                        new ItemDefect
                        {
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Backing Shield").ItemId,
                            DefectId = context.Defects.FirstOrDefault(f => f.DefectName == "Incorrect hardware").DefectId
                        },
                        new ItemDefect
                        {
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Side Arm").ItemId,
                            DefectId = context.Defects.FirstOrDefault(f => f.DefectName == "Incorrect specification").DefectId
                        },
                        new ItemDefect
                        {
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Panel").ItemId,
                            DefectId = context.Defects.FirstOrDefault(f => f.DefectName == "Incorrect dimensions").DefectId
                        });

                    context.SaveChanges();
                }

                if (!context.ProcessApplicables.Any())
                {
                    context.ProcessApplicables.AddRange(
                        new ProcessApplicable
                        {
                            ProAppName = "Supplier or Rec-Insp"
                        },
                        new ProcessApplicable
                        {
                            ProAppName = "WIP (Production Order)"
                        });

                    context.SaveChanges();
                }

                if (!context.StatusUpdates.Any())
                {
                    context.StatusUpdates.AddRange(
                        new StatusUpdate
                        {
                            StatusUpdateName = "Active"
                        },
                        new StatusUpdate
                        {
                            StatusUpdateName = "Closed"
                        });

                    context.SaveChanges();
                }

                if (!context.Ncrs.Any())
                {
                    context.Ncrs.AddRange(
                        new Ncr
                        {
                            NcrNumber = "2023-137",
                            NcrLastUpdated = DateTime.Parse("2023-12-18"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-138",
                            NcrLastUpdated = DateTime.Parse("2023-12-19"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-139",
                            NcrLastUpdated = DateTime.Parse("2023-12-22"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-140",
                            NcrLastUpdated = DateTime.Parse("2024-01-18"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-141",
                            NcrLastUpdated = DateTime.Parse("2024-01-14"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-001",
                            NcrLastUpdated = DateTime.Parse("2024-01-10"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-002",
                            NcrLastUpdated = DateTime.Parse("2024-01-11"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-003",
                            NcrLastUpdated = DateTime.Parse("2024-01-15"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-004",
                            NcrLastUpdated = DateTime.Parse("2024-01-19"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-005",
                            NcrLastUpdated = DateTime.Parse("2024-01-22"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-006",
                            NcrLastUpdated = DateTime.Parse("2024-01-23"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-007",
                            NcrLastUpdated = DateTime.Parse("2024-01-23"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Active").StatusUpdateId
                        });
                    context.SaveChanges();
                }

                if (!context.NcrQas.Any())
                {
                    context.NcrQas.AddRange(
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "12345",
                            NcrQacreationDate = DateTime.Parse("2023-12-07"),
                            NcrQalastUpdated = DateTime.Parse("2023-12-07"),
                            NcrQauserId = 1, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-137").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "12346",
                            NcrQacreationDate = DateTime.Parse("2023-12-09"),
                            NcrQalastUpdated = DateTime.Parse("2023-12-09"),
                            NcrQauserId = 2, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-138").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "98765",
                            NcrQacreationDate = DateTime.Parse("2023-12-11"),
                            NcrQalastUpdated = DateTime.Parse("2023-12-11"),
                            NcrQauserId = 3, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-139").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "64162",
                            NcrQacreationDate = DateTime.Parse("2023-12-13"),
                            NcrQalastUpdated = DateTime.Parse("2023-12-13"),
                            NcrQauserId = 4, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "WIP (Production Order)").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-140").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "98766",
                            NcrQacreationDate = DateTime.Parse("2023-12-17"),
                            NcrQalastUpdated = DateTime.Parse("2023-12-17"),
                            NcrQauserId = 1, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-141").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "87654",
                            NcrQacreationDate = DateTime.Parse("2024-01-03"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-03"),
                            NcrQauserId = 2, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "76543",
                            NcrQacreationDate = DateTime.Parse("2024-01-04"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-04"),
                            NcrQauserId = 3, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-002").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "55554",
                            NcrQacreationDate = DateTime.Parse("2024-01-06"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-06"),
                            NcrQauserId = 4, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "WIP (Production Order)").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-003").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "32145",
                            NcrQacreationDate = DateTime.Parse("2024-01-07"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-07"),
                            NcrQauserId = 1, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-004").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "34345",
                            NcrQacreationDate = DateTime.Parse("2024-01-11"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-11"),
                            NcrQauserId = 2, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-005").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "45456",
                            NcrQacreationDate = DateTime.Parse("2024-01-14"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-14"),
                            NcrQauserId = 3, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-006").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "56567",
                            NcrQacreationDate = DateTime.Parse("2024-01-14"),
                            NcrQalastUpdated = DateTime.Parse("2024-01-14"),
                            NcrQauserId = 4, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "WIP (Production Order)").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-007").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.OrderDetails.Any())
                {
                    context.OrderDetails.AddRange(
                        new OrderDetail
                        {
                            OrderNumber = 32778899,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Bearing Housing").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "12345").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 34377801,
                            OrderQuanReceived = 5,
                            OrderQuanDefective = 1,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Backing Shield").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "12346").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 88786565,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Side Arm").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "98765").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 33566400,
                            OrderQuanReceived = 40,
                            OrderQuanDefective = 8,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Panel").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "64162").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 99832323,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Bearing Housing").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "98766").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 66654309,
                            OrderQuanReceived = 5,
                            OrderQuanDefective = 1,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Backing Shield").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "87654").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 88977653,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Side Arm").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "76543").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 22445435,
                            OrderQuanReceived = 40,
                            OrderQuanDefective = 8,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Panel").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "55554").NcrQaid
                        },
                                                new OrderDetail
                        {
                            OrderNumber = 55478341,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Bearing Housing").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "32145").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 12758492,
                            OrderQuanReceived = 5,
                            OrderQuanDefective = 1,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Backing Shield").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "34345").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 99876563,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Side Arm").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "45456").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 43565459,
                            OrderQuanReceived = 40,
                            OrderQuanDefective = 8,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Panel").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "56567").NcrQaid
                        });

                    context.SaveChanges();
                }

                if (!context.EngDispositionTypes.Any())
                {
                    context.EngDispositionTypes.AddRange(
                        new EngDispositionType
                        {
                            EngDispositionTypeName = "N/A"
                        },
                        new EngDispositionType
                        {
                            EngDispositionTypeName = "Drawing updated for correct dimensions."
                        });

                    context.SaveChanges();
                }

                if (!context.NcrEngs.Any())
                {
                    context.NcrEngs.AddRange(
                        new NcrEng
                        {
                            NcrEngCustomerNotification = false,
                            NcrEngDispositionDescription = "Example Description of Disposition 1",
                            NcrEngLastUpdated = DateTime.Parse("2023-12-08"),
                            NcrEngCreationDate = DateTime.Parse("2023-12-08"),
                            NcrEngUserId = 1, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-137").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 2",
                            NcrEngLastUpdated = DateTime.Parse("2023-12-10"),
                            NcrEngCreationDate = DateTime.Parse("2023-12-10"),
                            NcrEngUserId = 2, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-138").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 3",
                            NcrEngLastUpdated = DateTime.Parse("2023-12-16"),
                            NcrEngCreationDate = DateTime.Parse("2023-12-16"),
                            NcrEngUserId = 3, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-139").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 4",
                            NcrEngLastUpdated = DateTime.Parse("2023-12-16"),
                            NcrEngCreationDate = DateTime.Parse("2023-12-16"),
                            NcrEngUserId = 4, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-140").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = false,
                            NcrEngDispositionDescription = "Example Description of Disposition 5",
                            NcrEngLastUpdated = DateTime.Parse("2023-12-19"),
                            NcrEngCreationDate = DateTime.Parse("2023-12-19"),
                            NcrEngUserId = 1, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-141").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 6",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-04"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-04"),
                            NcrEngUserId = 2, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 7",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-06"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-06"),
                            NcrEngUserId = 3, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-002").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 8",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-07"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-07"),
                            NcrEngUserId = 4, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-003").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = false,
                            NcrEngDispositionDescription = "Example Description of Disposition 9",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-08"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-08"),
                            NcrEngUserId = 1, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-004").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 10",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-12"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-12"),
                            NcrEngUserId = 2, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-005").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 11",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-14"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-14"),
                            NcrEngUserId = 3, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-006").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 12",
                            NcrEngLastUpdated = DateTime.Parse("2024-01-18"),
                            NcrEngCreationDate = DateTime.Parse("2024-01-18"),
                            NcrEngUserId = 4, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-007").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.Drawings.Any())
                {
                    context.Drawings.AddRange(
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 1,
                            DrawingUpdatedRevNumber = 2,
                            DrawingRevDate = DateTime.Parse("2023-12-08"),
                            DrawingUserId = 1, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 1").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 3,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2023-12-10"),
                            DrawingUserId = 2, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 2").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 5,
                            DrawingUpdatedRevNumber = 6,
                            DrawingRevDate = DateTime.Parse("2023-12-16"),
                            DrawingUserId = 3, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 3").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 7,
                            DrawingUpdatedRevNumber = 8,
                            DrawingRevDate = DateTime.Parse("2023-12-16"),
                            DrawingUserId = 4, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 4").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 1,
                            DrawingUpdatedRevNumber = 3,
                            DrawingRevDate = DateTime.Parse("2023-12-19"),
                            DrawingUserId = 1, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 5").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 2,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2024-01-04"),
                            DrawingUserId = 2, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 6").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 3,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2024-01-06"),
                            DrawingUserId = 3, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 7").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 4,
                            DrawingUpdatedRevNumber = 7,
                            DrawingRevDate = DateTime.Parse("2024-01-07"),
                            DrawingUserId = 4, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 8").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 1,
                            DrawingUpdatedRevNumber = 3,
                            DrawingRevDate = DateTime.Parse("2024-01-08"),
                            DrawingUserId = 1, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 9").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 2,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2024-01-12"),
                            DrawingUserId = 2, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 10").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 3,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2024-01-14"),
                            DrawingUserId = 3, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 11").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 4,
                            DrawingUpdatedRevNumber = 7,
                            DrawingRevDate = DateTime.Parse("2024-01-18"),
                            DrawingUserId = 4, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 12").NcrEngId //THIS MUST CHANGE
                        });
                    context.SaveChanges();
                }

                if (!context.FollowUpTypes.Any())
                {
                    context.FollowUpTypes.AddRange(
                        new FollowUpType
                        {
                            FollowUpTypeName = "Resolution"
                        },
                        new FollowUpType
                        {
                            FollowUpTypeName = "Clarification"
                        },
                        new FollowUpType
                        {
                            FollowUpTypeName = "Feedback"
                        },
                        new FollowUpType
                        {
                            FollowUpTypeName = "Update"
                        });

                    context.SaveChanges();
                }

                if (!context.OpDispositionTypes.Any())
                {
                    context.OpDispositionTypes.AddRange(
                        new OpDispositionType
                        {
                            OpDispositionTypeName = "N/A"
                        },
                        new OpDispositionType
                        {
                            OpDispositionTypeName = "Rework per engineering disposition."
                        },
                        new OpDispositionType
                        {
                            OpDispositionTypeName = "Replacement required."
                        });

                    context.SaveChanges();
                }

                if (!context.NcrPurchasings.Any())
                {
                    context.NcrPurchasings.AddRange(
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Replacement required",
                            NcrPurchCreationDate = DateTime.Parse("2023-12-09"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2023-12-09"),
                            NcrPurchasingUserId = 1, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "N/A").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-137").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2023-12-11"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2023-12-11"),
                            NcrPurchasingUserId = 2, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Replacement required.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-138").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2023-12-17"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2023-12-17"),
                            NcrPurchasingUserId = 3, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-139").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Rework per engineering disposition",
                            NcrPurchCreationDate = DateTime.Parse("2023-12-17"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2023-12-17"),
                            NcrPurchasingUserId = 4, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-140").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Replacement required",
                            NcrPurchCreationDate = DateTime.Parse("2023-12-20"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2023-12-20"),
                            NcrPurchasingUserId = 5, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "N/A").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-141").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-05"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-05"),
                            NcrPurchasingUserId = 6, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Replacement required.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-07"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-07"),
                            NcrPurchasingUserId = 7, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-002").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Rework per engineering disposition",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-08"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-08"),
                            NcrPurchasingUserId = 8, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-003").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Replacement required",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-09"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-09"),
                            NcrPurchasingUserId = 9, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "N/A").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-004").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-13"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-13"),
                            NcrPurchasingUserId = 10, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Replacement required.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-005").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Use as is",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-15"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-15"),
                            NcrPurchasingUserId = 11, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-006").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchasingDescription = "Rework per engineering disposition",
                            NcrPurchCreationDate = DateTime.Parse("2024-01-19"),
                            NcrPurchasingLastUpdated = DateTime.Parse("2024-01-19"),
                            NcrPurchasingUserId = 12, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-007").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.FollowUps.Any())
                {
                    context.FollowUps.AddRange(
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-12-10"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Resolution").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 1).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-12-12"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Clarification").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 2).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-12-18"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Feedback").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 3).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-12-18"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Update").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 4).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-12-21"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Resolution").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 5).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-06"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Clarification").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 6).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-08"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Feedback").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 7).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-09"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Update").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 8).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-10"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Resolution").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 9).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-14"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Clarification").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 10).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-16"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Feedback").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 11).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2024-01-20"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Update").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 12).NcrPurchId //THIS MUST CHANGE
                        });

                    context.SaveChanges();
                }

                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(
                        new Car
                        {
                            CarNumber = 3456,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 1).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 1243,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 2).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 7542,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 3).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 9253,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 4).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 2618,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 5).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 8723,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 6).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 9231,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 7).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 7772,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 8).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 3290,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 9).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 6666,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 10).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 4411,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 11).NcrPurchId //THIS MUST CHANGE
                        },
                        new Car
                        {
                            CarNumber = 1592,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 12).NcrPurchId //THIS MUST CHANGE
                        });

                    context.SaveChanges();
                }

                if (!context.NcrReInspects.Any())
                {
                    context.NcrReInspects.AddRange(
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2023-12-11"),
                            NcrReInspectLastUpdated = DateTime.Parse("2023-12-11"),
                            NcrReInspectUserId = 1, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-137").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2023-12-13"),
                            NcrReInspectLastUpdated = DateTime.Parse("2023-12-13"),
                            NcrReInspectUserId = 2, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-138").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,

                            NcrReInspectCreationDate = DateTime.Parse("2023-12-19"),
                            NcrReInspectLastUpdated = DateTime.Parse("2023-12-19"),
                            NcrReInspectUserId = 3, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-139").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2023-12-19"),
                            NcrReInspectLastUpdated = DateTime.Parse("2023-12-19"),
                            NcrReInspectUserId = 4, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-140").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2023-12-22"),
                            NcrReInspectLastUpdated = DateTime.Parse("2023-12-22"),
                            NcrReInspectUserId = 1, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-141").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-07"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-07"),
                            NcrReInspectUserId = 2, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-09"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-09"),
                            NcrReInspectUserId = 3, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-002").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-10"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-10"),
                            NcrReInspectUserId = 4, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-003").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-11"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-11"),
                            NcrReInspectUserId = 1, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-004").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-15"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-15"),
                            NcrReInspectUserId = 2, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-005").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-17"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-17"),
                            NcrReInspectUserId = 3, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-006").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-21"),
                            NcrReInspectLastUpdated = DateTime.Parse("2024-01-21"),
                            NcrReInspectUserId = 4, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-007").NcrId
                        });
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
