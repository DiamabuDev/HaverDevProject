using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using HaverDevProject.Models;

namespace HaverDevProject.Data
{
    public static class HaverInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            HaverContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<HaverContext>();

            try
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                //context.Database.Migrate();

                /*
                if (!context.Ncrs.Any())
                {
                    context.Ncrs.AddRange(
                        new Ncr
                        {
                            NcrNumber = "25338",
                            NcrLastModified = DateTime.Parse("2023-12-20"),
                            StatusUpdateId = 1
                        },
                        new Ncr
                        {
                            NcrNumber = "25339",
                            NcrLastModified = DateTime.Parse("2024-01-13"),
                            StatusUpdateId = 2
                        },
                        new Ncr
                        {
                            NcrNumber = "32902",
                            NcrLastModified = DateTime.Now,
                            StatusUpdateId = 3
                        },
                        new Ncr
                        {
                            NcrNumber = "33021",
                            NcrLastModified = DateTime.Now,
                            StatusUpdateId = 4
                        });
                    context.SaveChanges();
                }

                if (!context.ncrEngs.Any())
                {
                    context.ncrEngs.AddRange(
                        new NcrEng
                        {
                            NcrEngCustomerNotification = false,
                            NcrEngDispositionDescription = "Disposition example 1",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEndCreationDate = DateTime.Now,
                            NcrEngUserId = 1,
                            EngDispositionTypeId = 1,
                            NcrId = 1
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Disposition example 2",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEndCreationDate = DateTime.Now,
                            NcrEngUserId = 2,
                            EngDispositionTypeId = 2,
                            NcrId = 2
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEndCreationDate = DateTime.Parse("2023-08-04"),
                            NcrEngUserId = 3,
                            EngDispositionTypeId = 3,
                            NcrId = 3
                        },
                        new NcrEng
                        {
                            NcrEngCustomerNotification = true,
                            NcrEngDispositionDescription = "Example Description of Disposition",
                            NcrEngLastUpdated = DateTime.Now,
                            NcrEndCreationDate = DateTime.Parse("2023-10-25"),
                            NcrEngUserId = 4,
                            EngDispositionTypeId = 4,
                            NcrId = 5
                        });
                    context.SaveChanges();
                }

                if (!context.NcrPurchasings.Any())
                {
                    context.NcrPurchasings.AddRange(
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Now,
                            NcrPurchasingLastUpdate = DateTime.Now,
                            NcrPurchasingUserId = 1,
                            OpDispositionTypeId = 1,
                            NcrId = 1,
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Now,
                            NcrPurchasingLastUpdate = DateTime.Now,
                            NcrPurchasingUserId = 2,
                            OpDispositionTypeId = 2,
                            NcrId = 2,
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2023-05-17"),
                            NcrPurchasingLastUpdate = DateTime.Now,
                            NcrPurchasingUserId = 3,
                            OpDispositionTypeId = 3,
                            NcrId = 3,
                        },
                        new NcrPurchasing
                        {
                            NcrPurchCreationDate = DateTime.Parse("2022-12-24"),
                            NcrPurchasingLastUpdate = DateTime.Now,
                            NcrPurchasingUserId = 4,
                            OpDispositionTypeId = 4,
                            NcrId = 4,
                        });
                    context.SaveChanges();
                }

                if (!context.NcrQas.Any())
                {
                    context.NcrQas.AddRange(
                        new NcrQa
                        {
                            NcrQaid = 1,
                            PurchaseOrderId = 1,
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "12345",
                            NcrQacreationDate = DateTime.Now,
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 1,
                            ProAppId = 1,
                            NcrId = 1
                        },
                        new NcrQa
                        {
                            NcrQaid = 2,
                            PurchaseOrderId = 2,
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "12346",
                            NcrQacreationDate = DateTime.Now,
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 2,
                            ProAppId = 2,
                            NcrId = 2
                        },
                        new NcrQa
                        {
                            NcrQaid = 3,
                            PurchaseOrderId = 3,
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "98765",
                            NcrQacreationDate = DateTime.Parse("2023-03-01"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 3,
                            ProAppId = 3,
                            NcrId = 3
                        },
                        new NcrQa
                        {
                            NcrQaid = 4,
                            PurchaseOrderId = 4,
                            NcrQaitemMarNonConforming = true,
                            NcrQasalesOrder = "64162",
                            NcrQacreationDate = DateTime.Parse("2024-01-01"),
                            NcrQalastUpdated = DateTime.Now,
                            NcrQauserId = 4,
                            ProAppId = 4,
                            NcrId = 4
                        });
                    context.SaveChanges();
                }

                if (!context.NcrReInspects.Any())
                {
                    context.NcrReInspects.AddRange(
                        new NcrReInspect
                        {
                            NcrReInspectId = 1,
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 1,
                            NcrReInspectCreationDate = DateTime.Now,
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 1,
                            NcrId = 1
                        },
                        new NcrReInspect
                        {
                            NcrReInspectId = 2,
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 2,
                            NcrReInspectCreationDate = DateTime.Now,
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 2,
                            NcrId = 2
                        },
                        new NcrReInspect
                        {
                            NcrReInspectId = 3,
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 3,
                            NcrReInspectCreationDate = DateTime.Parse("2023-07-21"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 3,
                            NcrId = 3
                        },
                        new NcrReInspect
                        {
                            NcrReInspectId = 4,
                            NcrReInspectAcceptable = true,
                            NcrReInspectNewNcrNumber = 4,
                            NcrReInspectCreationDate = DateTime.Parse("2023-10-10"),
                            NcrReInspectLastUpdated = DateTime.Now,
                            NcrReInspectUserId = 4,
                            NcrId = 4
                        });
                    context.SaveChanges();
                }    */      
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
