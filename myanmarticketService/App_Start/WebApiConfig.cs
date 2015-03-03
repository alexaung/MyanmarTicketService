using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using System.Data.Entity.Migrations;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;
//using myanmarticketService.Migrations;

namespace myanmarticketService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            //Database.SetInitializer(new myanmarticketInitializer());
            //var migrator = new DbMigrator(new Configuration());
            //migrator.Update();  
        }
    }

    //public class myanmarticketInitializer : ClearDatabaseSchemaIfModelChanges<myanmarticketContext>
    //{
    //    protected override void Seed(myanmarticketContext context)
    //    {
           
    //        context.Cars.AddRange(new List<Car>
    //        {
    //            new Car { Id = Guid.NewGuid().ToString(), Image = "ic_highlander", Name = "Highlander", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
    //            new Car { Id = Guid.NewGuid().ToString(), Image = "ic_super_custom", Name = "Super Custom", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
    //            new Car { Id = Guid.NewGuid().ToString(), Image = "ic_mark_ii_grande", Name = "MarkII GRANDE", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
    //            new Car { Id = Guid.NewGuid().ToString(), Image = "ic_hiace_commuter_13", Name = "Hiace commuter", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "MDL" },

    //        });

    //        //context.States.AddRange(new List<State>{
    //        //    new State { Code = "AY",  Name = "Ayeyarwady" },
    //        //    new State { Code = "BA",  Name = "Bago" },
    //        //    new State { Code = "CH",  Name = "Chin" },
    //        //    new State { Code = "KC",  Name = "Kachin" },
    //        //    new State { Code = "KH",  Name = "Kayah" },
    //        //    new State { Code = "KN",  Name = "Kayin" },
    //        //    new State { Code = "MG",  Name = "Magway" },
    //        //    new State { Code = "ML",  Name = "Mandalay" },
    //        //    new State { Code = "MO",  Name = "Mon" },
    //        //    new State { Code = "NY",  Name = "Naypyidaw" },
    //        //    new State { Code = "RA",  Name = "Rakhine" },
    //        //    new State { Code = "SA",  Name = "Sagaing" },
    //        //    new State { Code = "SH",  Name = "Shan" },
    //        //    new State { Code = "TN",  Name = "Tanintharyi" },
    //        //    new State { Code = "YA",  Name = "Yangon" }
    //        //});
    //        var AY = new State { Code = "AY",  Name = "Ayeyarwady" };
    //        var BA = new State { Code = "BA", Name = "Bago" };
    //        var CH = new State { Code = "CH", Name = "Chin" };
    //        var KC =     new State { Code = "KC",  Name = "Kachin" };
    //        var KH =     new State { Code = "KH",  Name = "Kayah" };
    //        var KN =     new State { Code = "KN",  Name = "Kayin" };
    //        var MG =     new State { Code = "MG",  Name = "Magway" };
    //        var ML =     new State { Code = "ML",  Name = "Mandalay" };
    //        var MO =     new State { Code = "MO",  Name = "Mon" };
    //        var NY =     new State { Code = "NY",  Name = "Naypyidaw" };
    //        var RA =     new State { Code = "RA",  Name = "Rakhine" };
    //        var SA =     new State { Code = "SA",  Name = "Sagaing" };
    //        var SH =     new State { Code = "SH",  Name = "Shan" };
    //        var TN =     new State { Code = "TN",  Name = "Tanintharyi" };
    //        var YA = new State { Code = "YA", Name = "Yangon" };

    //        context.Cities.AddRange(new List<City> { 
    //            /* Ayeyarwady */
                
    //            /* Bagon */
    //            new City { State = BA, Name="Pyay (Prome)" },   
    //            new City { State = BA, Name="Wethtikan" },   
    //            new City { State = BA, Name="Paungdale" },
    //            /* Chin */

    //            /* Kachin */

    //            /* Kayah */

    //            /* Kayin */
    //            new City { State = KN,  Name="Hpa-an" },   
    //            new City { State = KN, Name="Myawaddy (Myawadi)" },   
                
    //            /* Magway */
    //            new City { State = MG, Name="Taungdwingyi" },  
    //            new City { State = MG, Name="Thityarkauk" },  
    //            new City { State = MG, Name="Mekyaungye" },  
    //            new City { State = MG, Name="Myothit" },  
    //            new City { State = MG, Name="Aunglan" }, 
                    
    //            /* Mandalay */
    //            new City { State = ML, Name="Mandalay" },   
    //            new City { State = ML, Name="Meiktila" },   
    //            new City { State = ML, Name="Yamethin" },   
    //            new City { State = ML, Name="Pyawbwe" },   
    //            new City { State = ML, Name="Wundwin" },   
    //            new City { State = ML, Name="Kyaukse" },  
    //            new City { State = ML, Name="Kume" },  
    //            new City { State = ML, Name="Sintgaing" },  
    //            new City { State = ML, Name="Pyinoolwin" },  
    //            new City { State = ML, Name="Yae U" },
                
    //            /* Mon */
    //            new City { State = MO, Name="Mawlamyaing" },
    //            new City { State = MO, Name="Mudon" },
    //            new City { State = MO, Name="Thanbyuzayat" },
                
    //            /* Naypyidaw */
    //            new City { State = NY, Name="Naypyidaw" },   
    //            new City { State = NY, Name="Tatkon" },   
                
    //            /* Rakhine */

    //            /* Sagaing */
    //            new City { State = SA, Name="Monywa" },
    //            new City { State = SA, Name="Pale" },
    //            new City { State = SA, Name="Ayadaw" },

    //            /* Shan */

    //            /* Tanintharyi */
    //            new City { State = TN, Name="Myeik" },
    //            new City { State = TN, Name="Dawei" },

    //            /* Yangon */
    //            new City { State = YA, Name="Yangon" }
    //        });

    //        base.Seed(context);
    //    }
    //}
}

