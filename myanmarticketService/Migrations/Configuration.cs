namespace myanmarticketService.Migrations
{
    using myanmarticketService.DataObjects;
    using myanmarticketService.DataObjects.BusTicket;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<myanmarticketService.Models.myanmarticketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(myanmarticketService.Models.myanmarticketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Cars.AddOrUpdate(c => c.Id,

                new Car { Id = "60B0891B-C3CF-41A6-9BE0-BCCCE5949E6B", Image = "ic_highlander", Name = "Highlander", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = "BAA205B5-C43F-490E-A83B-81F0EBDA2D97", Image = "ic_super_custom", Name = "Super Custom", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = "DD68E56D-3967-4D32-A959-BEFBCB70FC4B", Image = "ic_mark_ii_grande", Name = "MarkII GRANDE", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = "8EDDC308-FB63-469B-8A6A-B2360D61892D", Image = "ic_hiace_commuter_13", Name = "Hiace commuter", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "MDL" }
            );

            context.States.AddOrUpdate(s => s.Id,

                new State { Id = "5FEAB2AE-0EB8-495F-8D86-B9D314BBE0C2", Code = "AY", Name = "Ayeyarwady" },
                new State { Id = "F18F450F-484E-4C96-AFCD-CFC77E0A139B", Code = "BA", Name = "Bago" },
                new State { Id = "D3A3315A-E11F-4A75-889E-D73A9F110037", Code = "CH", Name = "Chin" },
                new State { Id = "440CC9B3-1C37-4A5C-9448-128235129957", Code = "KC", Name = "Kachin" },
                new State { Id = "0C0356A5-B833-4A80-BE3D-90C0E23C46E3", Code = "KH", Name = "Kayah" },
                new State { Id = "BE448568-7E24-4CE1-98D6-6EA3F48C74A8", Code = "KN", Name = "Kayin" },
                new State { Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Code = "MG", Name = "Magway" },
                new State { Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Code = "ML", Name = "Mandalay" },
                new State { Id = "DBFFAA3E-C021-4806-BD49-3E38022BF9C4", Code = "MO", Name = "Mon" },
                new State { Id = "64376A94-A581-4E1A-8595-D01FE0765CFB", Code = "NY", Name = "Naypyidaw" },
                new State { Id = "A8212212-434C-4C0D-A4FB-C46ED411CA50", Code = "RA", Name = "Rakhine" },
                new State { Id = "A8DC65F7-737E-41A7-A039-AADE238700EC", Code = "SA", Name = "Sagaing" },
                new State { Id = "77C8BA6F-D20A-4A6E-95B9-79691619F636", Code = "SH", Name = "Shan" },
                new State { Id = "A8D61251-8448-443E-B900-B764613ECCC1", Code = "TN", Name = "Tanintharyi" },
                new State { Id = "AF4C0A10-2CA4-4087-84C0-E463F22145F6", Code = "YA", Name = "Yangon" }
            );

            context.Cities.AddOrUpdate(c => c.Id,
                /* Ayeyarwady */

                /* Bagon */
                new City { Id = "34636555-9D19-4A79-9AF4-CC96670C79CE", State_Id = "F18F450F-484E-4C96-AFCD-CFC77E0A139B", Name = "Pyay (Prome)" },
                new City { Id = "C09F0519-6328-4B44-B5B9-9AEA7C43D298", State_Id = "F18F450F-484E-4C96-AFCD-CFC77E0A139B", Name = "Wethtikan" },
                new City { Id = "E9E93B9D-EE74-4C8D-9E0E-501DFF906BB2", State_Id = "F18F450F-484E-4C96-AFCD-CFC77E0A139B", Name = "Paungdale" },
                /* Chin */

                /* Kachin */

                /* Kayah */

                /* Kayin */
                new City { Id = "5DFCF589-8F03-461F-A009-ECBCA723CDBA", State_Id = "BE448568-7E24-4CE1-98D6-6EA3F48C74A8", Name = "Hpa-an" },
                new City { Id = "7FA03827-8CA8-43F6-B4A1-F3017338027B", State_Id = "BE448568-7E24-4CE1-98D6-6EA3F48C74A8", Name = "Myawaddy (Myawadi)" },

                /* Magway */
                new City { Id = "281DDCA5-7BB2-4092-831F-285F90E426C9", State_Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Name = "Taungdwingyi" },
                new City { Id = "9FA80C83-0C0F-44A3-9EBC-1DD53AE1E999", State_Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Name = "Thityarkauk" },
                new City { Id = "7777E95A-276A-4970-8ADD-8A026CCBF246", State_Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Name = "Mekyaungye" },
                new City { Id = "E07B9193-E77D-4CBE-8CDE-A00BCEE447DB", State_Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Name = "Myothit" },
                new City { Id = "F5A3D7EA-986B-487C-B38B-9B6065C14818", State_Id = "AB2F909E-5E94-48BB-BBD2-D6367A443FF2", Name = "Aunglan" },

                /* Mandalay */
                new City { Id = "413069CF-56BD-4C07-BF01-35EAAC42073B", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Mandalay" },
                new City { Id = "3E2D7EB8-50BE-4D46-AAFB-CDAE58972C3B", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Meiktila" },
                new City { Id = "091AB488-F8DB-463E-904B-E07A631D6234", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Yamethin" },
                new City { Id = "55E899B9-BD0E-4041-870E-31942A9F2150", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Pyawbwe" },
                new City { Id = "E6BC0FBC-6DA7-4B85-A409-4088F0820F76", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Wundwin" },
                new City { Id = "7019C609-57B8-4ADB-B028-A182952AB291", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Kyaukse" },
                new City { Id = "52D4634E-37F3-45E9-8D1F-E6D8027BB70B", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Kume" },
                new City { Id = "89356AE2-66D2-438C-87CA-025BEAB9661B", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Sintgaing" },
                new City { Id = "67B97667-6A9E-4DF2-8BEB-EA0B39EC8F43", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Pyinoolwin" },
                new City { Id = "AA35E6B0-9053-4174-A77E-9D08010FF5B8", State_Id = "A15B0A80-75D9-47BB-B493-D5F5899F7B8B", Name = "Yae U" },

                /* Mon */
                new City { Id = "C7DF6DD0-A223-42F3-86DA-D4FDB6C1E258", State_Id = "DBFFAA3E-C021-4806-BD49-3E38022BF9C4", Name = "Mawlamyaing" },
                new City { Id = "2450F63D-910F-41D9-8E2B-E80EE9A5D9C8", State_Id = "DBFFAA3E-C021-4806-BD49-3E38022BF9C4", Name = "Mudon" },
                new City { Id = "3AE09873-2CCF-411F-BB33-16CE7E3C4248", State_Id = "DBFFAA3E-C021-4806-BD49-3E38022BF9C4", Name = "Thanbyuzayat" },

                /* Naypyidaw */
                new City { Id = "3DA180A7-335E-49C5-A026-B7D6D891571B", State_Id = "64376A94-A581-4E1A-8595-D01FE0765CFB", Name = "Naypyidaw" },
                new City { Id = "EB959621-DFD3-472A-A369-363130533A25", State_Id = "64376A94-A581-4E1A-8595-D01FE0765CFB", Name = "Tatkon" },

                /* Rakhine */

                /* Sagaing */
                new City { Id = "4BAFE41D-B88A-487A-8429-F4FAC9498B1C", State_Id = "A8DC65F7-737E-41A7-A039-AADE238700EC", Name = "Monywa" },
                new City { Id = "578D9AB3-C49F-4FE3-B3D8-9CDFB78EB27A", State_Id = "A8DC65F7-737E-41A7-A039-AADE238700EC", Name = "Pale" },
                new City { Id = "0A07F700-F83E-4F4F-AD25-0F9C86B1043F", State_Id = "A8DC65F7-737E-41A7-A039-AADE238700EC", Name = "Ayadaw" },

                /* Shan */

                /* Tanintharyi */
                new City { Id = "434CA72C-95FD-47FD-86B8-095B47391742", State_Id = "A8D61251-8448-443E-B900-B764613ECCC1", Name = "Myeik" },
                new City { Id = "A31835C8-AFF9-4F39-9154-EAB79A6EAD94", State_Id = "A8D61251-8448-443E-B900-B764613ECCC1", Name = "Dawei" },

                /* Yangon */
                new City { Id = "B7B37A1D-6DE9-4D54-AF12-B8E0AE8A94F9", State_Id = "AF4C0A10-2CA4-4087-84C0-E463F22145F6", Name = "Yangon" }
            );

            context.BusTypes.AddOrUpdate(bt => bt.Id,
                    new BusType { Id = "2992C810-6A21-475E-A524-59B83AFFEC62", Name = "Non A/C Semi Sleeper" },
                    new BusType { Id = "86097E95-643B-43A0-A0BB-2482DD6B0A62", Name = "Non A/C Sleeper" },
                    new BusType { Id = "2A8471D4-6E67-4A06-9B12-1F716C15C474", Name = "A/C Semi Sleeper" },
                    new BusType { Id = "6129CBA9-278C-405B-AEA8-770887CF333B", Name = "A/C Sleeper" },
                    new BusType { Id = "1AB74CF9-3F42-4113-949F-EBE34F545947", Name = "Non A/C Seater" },
                    new BusType { Id = "1DA77F81-DDBC-47E4-B1F4-0E5BF492FA14", Name = "Volvo A/C Multi Axle" },
                    new BusType { Id = "EB07AC09-84B9-4DA4-B734-21A37FC3E1AB", Name = "Volvo A/C Multi Axle SemiSleeper" },
                    new BusType { Id = "5613B02D-D364-4865-AA3F-FE68AB5D3A71", Name = "Mercedes Multi-Axle Semi-sleeper" }
                );

            context.BusStations.AddOrUpdate(bs => bs.Id,
                new BusStation { Id = "FBC3CD07-5C71-4954-8EF7-F5865A3948D3", Name = "Aung Mingalar Bus Station" },
                new BusStation { Id = "BA925A50-EC38-424E-9597-ABCB5F74F4D6", Name = " Monywa Highway Bus Station" }
                
                );

            context.ServiceProviders.AddOrUpdate(sp => sp.Id,
                new ServiceProvider { Id = "E0E0E7F9-F7FD-4AF4-B37C-672A6AA1DA42", Name = "TakeMeToMyanmr Pte Ltd", Email = "info@takemetomyanmar.com", Mobile = "(+95)926 153 7773", ContactPersonName = "Thi Han Lin", ContactNumber = "(+95)926 153 7773" });

            context.BusRoutes.AddOrUpdate(br => br.Id,
                new BusRoute
                {
                    Id = "B3DDDB9A-BC8A-46AB-AA6A-3313694D2806",
                    Name = "Moe Kaung Kin",
                    BusType_Id = "6129CBA9-278C-405B-AEA8-770887CF333B",
                    FromCity_Id = "B7B37A1D-6DE9-4D54-AF12-B8E0AE8A94F9",
                    ToCity_Id = "4BAFE41D-B88A-487A-8429-F4FAC9498B1C",
                    BoardingPoint_Id = "FBC3CD07-5C71-4954-8EF7-F5865A3948D3",
                    DroppingPoint_Id = "BA925A50-EC38-424E-9597-ABCB5F74F4D6",
                    Seats = 10,
                    Fare = 13,
                    DayOfWeek = 127
                }, 
                new BusRoute
                {
                    Id = "DAB6C4EE-6877-4606-BBB9-EB379B64D2F3",
                    Name = "Moe Kaung Kin",
                    BusType_Id = "6129CBA9-278C-405B-AEA8-770887CF333B",
                    FromCity_Id = "B7B37A1D-6DE9-4D54-AF12-B8E0AE8A94F9",
                    ToCity_Id = "578D9AB3-C49F-4FE3-B3D8-9CDFB78EB27A",
                    BoardingPoint_Id = "FBC3CD07-5C71-4954-8EF7-F5865A3948D3",
                    DroppingPoint_Id = "BA925A50-EC38-424E-9597-ABCB5F74F4D6",
                    Seats = 10,
                    Fare = 14,
                    DayOfWeek = 127
                });

            context.BusSchedules.AddOrUpdate(bsc => bsc.Id,
                new BusSchedule { Id = "F9F2BD13-0D39-482B-A567-4E5F20E39CF2", DepartureTime = "9:00 AM", ArrivalTime = "11:00 PM", BusRoute_Id = "B3DDDB9A-BC8A-46AB-AA6A-3313694D2806" },
                new BusSchedule { Id = "6B166FB8-45AB-4E49-B42C-CE58B952AD2A", DepartureTime = "8:00 AM", ArrivalTime = "07:00 PM", BusRoute_Id = "B3DDDB9A-BC8A-46AB-AA6A-3313694D2806" },

                new BusSchedule { Id = "A05D194E-B4FB-4962-A27A-26883C606850", DepartureTime = "5:00 PM", ArrivalTime = "04:00 AM", BusRoute_Id = "DAB6C4EE-6877-4606-BBB9-EB379B64D2F3" }
                );

            context.BusImages.AddOrUpdate(bi => bi.Id,
                new BusImage { Id = "35573EA2-C3BD-4C3E-A75A-2E88C8B4ADF0", Name = "B3DDDB9A-BC8A-46AB-AA6A-3313694D2806_1.jpg", BusRoute_Id = "B3DDDB9A-BC8A-46AB-AA6A-3313694D2806" },
                new BusImage { Id = "625090B7-9822-4816-B0F2-2E897C13280D", Name = "DAB6C4EE-6877-4606-BBB9-EB379B64D2F3_1.jpg", BusRoute_Id = "DAB6C4EE-6877-4606-BBB9-EB379B64D2F3" }
                );
        }
    }
}
