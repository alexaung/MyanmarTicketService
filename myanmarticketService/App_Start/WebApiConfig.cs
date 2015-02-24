using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects;
using myanmarticketService.DataObjects.BusTicket;
using myanmarticketService.Models;

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
            
            Database.SetInitializer(new myanmarticketInitializer());
        }
    }

    public class myanmarticketInitializer : ClearDatabaseSchemaIfModelChanges<myanmarticketContext>
    {
        protected override void Seed(myanmarticketContext context)
        {
           
            context.Cars.AddRange(new List<Car>
            {
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_highlander", Name = "Highlander", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_super_custom", Name = "Super Custom", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_mark_ii_grande", Name = "MarkII GRANDE", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_hiace_commuter_13", Name = "Hiace commuter", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "MDL" },

            });

            context.States.AddRange(new List<State>{
                new State { Code = "10",  Name = "Ayeyarwady" },
                new State { Code = "08",  Name = "Bago" },
                new State { Code = "03",  Name = "Chin" },
                new State { Code = "01",  Name = "Kachin" },
                new State { Code = "09",  Name = "Kayah" },
                new State { Code = "13",  Name = "Kayin" },
                new State { Code = "04",  Name = "Magway" },
                new State { Code = "05",  Name = "Mandalay" },
                new State { Code = "12",  Name = "Mon" },
                new State { Code = "05",  Name = "Naypyidaw" },
                new State { Code = "07",  Name = "Rakhine" },
                new State { Code = "02",  Name = "Sagaing" },
                new State { Code = "06",  Name = "Shan" },
                new State { Code = "14",  Name = "Tanintharyi" },
                new State { Code = "11",  Name = "Yangon" }
            });

            context.States.AddRange(new List<City> { 
                new City { StateCode = "02", Name="Monywa" },
                new City { StateCode = "02", Name="Pale" },
                new City { StateCode = "02", Name="Ayadaw" },

                new City { StateCode = "11", Name="Yangon" },
                
                new City { StateCode = "14", Name="Myeik" },
                new City { StateCode = "14", Name="Dawei" }
            });

            base.Seed(context);
        }
    }
}

