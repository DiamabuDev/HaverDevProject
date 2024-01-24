using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using HaverDevProject.Models;
using NuGet.DependencyResolver;

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
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                //context.Database.Migrate();


                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(
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
                }

                if (!context.Items.Any())
                {
                    context.Items.AddRange(
                        new Item
                        {
                            ItemNumber = 10344214,
                            ItemName = "Bearing Housing",
                            ItemDescription = "Protective enclosure for bearings.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "W S TYLER - PARTICLE & FINE").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 10482862,
                            ItemName = "Backing Shield",
                            ItemDescription = "Shield for internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "LAWRENCE SINTERED METALS").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11536286,
                            ItemName = "Side Arm",
                            ItemDescription = "Structural component for reinforcement.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "FASTENAL COMPANY").SupplierId
                        },
                        new Item
                        {
                            ItemNumber = 11854265,
                            ItemName = "Panel",
                            ItemDescription = "Surface to house internal components.",
                            SupplierId = context.Suppliers.FirstOrDefault(f => f.SupplierName == "HBC ENGINEERING").SupplierId
                        });
                }

                if (!context.Defects.Any())
                {
                    context.Defects.AddRange(
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
                        },
                        new StatusUpdate
                        {
                            StatusUpdateName = "In Progress"
                        });
                }

                if (!context.Ncrs.Any())
                {
                    context.Ncrs.AddRange(
                        new Ncr
                        {
                            NcrNumber = "2023-001",
                            NcrLastUpdated = DateTime.Parse("2024-01-01"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "Closed").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-002",
                            NcrLastUpdated = DateTime.Parse("2024-01-02"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "In Progress").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2023-003",
                            NcrLastUpdated = DateTime.Parse("2024-01-03"),
                            StatusUpdateId = context.StatusUpdates.FirstOrDefault(f => f.StatusUpdateName == "In Progress").StatusUpdateId
                        },
                        new Ncr
                        {
                            NcrNumber = "2024-001",
                            NcrLastUpdated = DateTime.Parse("2024-01-04"),
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
                            NcrQacreationDate = DateTime.Parse("2023-10-22"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 1, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-001").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "12346",
                            NcrQacreationDate = DateTime.Parse("2023-11-02"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 2, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-002").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "98765",
                            NcrQacreationDate = DateTime.Parse("2023-12-15"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 3, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "Supplier or Rec-Insp").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-003").NcrId
                        },
                        new NcrQa
                        {
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "64162",
                            NcrQacreationDate = DateTime.Parse("2024-01-01"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 4, //need to make nullable
                            ProAppId = context.ProcessApplicables.FirstOrDefault(f => f.ProAppName == "WIP (Production Order)").ProAppId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.OrderDetails.Any())
                {
                    context.OrderDetails.AddRange(
                        new OrderDetail
                        {
                            OrderNumber = 12345678,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Bearing Housing").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "12345").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 12758492,
                            OrderQuanReceived = 5,
                            OrderQuanDefective = 1,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Backing Shield").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "12346").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 12345678,
                            OrderQuanReceived = 10,
                            OrderQuanDefective = 2,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Side Arm").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "98765").NcrQaid
                        },
                        new OrderDetail
                        {
                            OrderNumber = 12345678,
                            OrderQuanReceived = 40,
                            OrderQuanDefective = 8,
                            ItemId = context.Items.FirstOrDefault(f => f.ItemName == "Panel").ItemId,
                            NcrQaid = context.NcrQas.FirstOrDefault(f => f.NcrQasalesOrder == "64162").NcrQaid
                        });
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
                }

                if (!context.NcrEngs.Any())
                {
                    context.NcrEngs.AddRange(
                        new NcrEng
                        {
                            NcrEngCustomerNotification = false,
                            NcrEngDispositionDescription = "Example Description of Disposition 1",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEngCreationDate = DateTime.Parse("2023-10-23"),
                            NcrEngUserId = 1, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-001").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 2",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEngCreationDate = DateTime.Parse("2023-11-03"),
                            NcrEngUserId = 2, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "N/A").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-002").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 3",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEngCreationDate = DateTime.Parse("2023-12-16"),
                            NcrEngUserId = 3, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-003").NcrId
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition 4",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEngCreationDate = DateTime.Parse("2024-1-02"),
                            NcrEngUserId = 4, //nullable
                            EngDispositionTypeId = context.EngDispositionTypes.FirstOrDefault(f => f.EngDispositionTypeName == "Drawing updated for correct dimensions.").EngDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.Drawings.Any())
                {
                    context.Drawings.AddRange(
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 1,
                            DrawingUpdatedRevNumber = 3,
                            DrawingRevDate = DateTime.Parse("2023-10-23"),
                            DrawingUserId = 1, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 1").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 2,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2023-11-03"),
                            DrawingUserId = 2, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 2").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 3,
                            DrawingUpdatedRevNumber = 4,
                            DrawingRevDate = DateTime.Parse("2023-12-16"),
                            DrawingUserId = 3, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 3").NcrEngId //THIS MUST CHANGE
                        },
                        new Drawing
                        {
                            DrawingOriginalRevNumber = 4,
                            DrawingUpdatedRevNumber = 7,
                            DrawingRevDate = DateTime.Parse("2024-1-02"),
                            DrawingUserId = 4, //need to make nullable
                            NcrEngId = context.NcrEngs.FirstOrDefault(f => f.NcrEngDispositionDescription == "Example Description of Disposition 4").NcrEngId //THIS MUST CHANGE
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
                }

                if (!context.NcrPurchasings.Any())
                {
                    context.NcrPurchasings.AddRange(
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2023-10-24"),
                            NcrPurchasingLastUpdated = DateTime.Now,
                            NcrPurchasingUserId = 1, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "N/A").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-001").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2023-11-04"),
                            NcrPurchasingLastUpdated = DateTime.Now,
                            NcrPurchasingUserId = 2, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Replacement required.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-002").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2023-12-17"),
                            NcrPurchasingLastUpdated = DateTime.Now,
                            NcrPurchasingUserId = 3, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-003").NcrId
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2024-1-03"),
                            NcrPurchasingLastUpdated = DateTime.Now,
                            NcrPurchasingUserId = 4, //need to make nullable
                            OpDispositionTypeId = context.OpDispositionTypes.FirstOrDefault(f => f.OpDispositionTypeName == "Rework per engineering disposition.").OpDispositionTypeId,
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
                        });
                    context.SaveChanges();
                }

                if (!context.FollowUps.Any())
                {
                    context.FollowUps.AddRange(
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-10-25"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Resolution").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 1).NcrPurchId //THIS MUST CHANGE
                        },
                        new FollowUp
                        {
                            FollowUpExpectedDate = DateTime.Parse("2023-11-05"),
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
                            FollowUpExpectedDate = DateTime.Parse("2024-01-04"),
                            FollowUpTypeId = context.FollowUpTypes.FirstOrDefault(f => f.FollowUpTypeName == "Update").FollowUpTypeId,
                            NcrPurchId = context.NcrPurchasings.FirstOrDefault(f => f.NcrPurchasingUserId == 4).NcrPurchId //THIS MUST CHANGE
                        });
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
                        });
                }

                if (!context.NcrReInspects.Any())
                {
                    context.NcrReInspects.AddRange(
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = null,
                            NcrReInspectCreationDate = DateTime.Parse("2023-10-25"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 1, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-001").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 1,
                            NcrReInspectCreationDate = DateTime.Parse("2023-11-05"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 2, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-002").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 2,
                            NcrReInspectCreationDate = DateTime.Parse("2023-12-18"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 3, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2023-003").NcrId
                        },
                        new NcrReInspect
                        {
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 3,
                            NcrReInspectCreationDate = DateTime.Parse("2024-01-04"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 4, //need to make nullable
                            NcrId = context.Ncrs.FirstOrDefault(f => f.NcrNumber == "2024-001").NcrId
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
