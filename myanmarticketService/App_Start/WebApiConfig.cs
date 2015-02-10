using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using myanmarticketService.DataObjects;
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
            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
                new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            };

            foreach (TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            List<Car> cars = new List<Car>
            {
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_highlander", Name = "Highlander", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_super_custom", Name = "Super Custom", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_mark_ii_grande", Name = "MarkII GRANDE", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "YGN" },
                new Car { Id = Guid.NewGuid().ToString(), Image = "ic_hiace_commuter_13", Name = "Hiace commuter", Description = "4 SEATER, FULL DAY (10 HRS), DOWNTOWN EXCLUDING INDUSTRIAL ZONE, WITH ENGLISH SPEAKING DRIVER", SeatingCapacity = 4, Luggage = 2, Rates = 20000.00M, AirportCode = "MDL" },

            };

            foreach (Car car in cars)
            {
                context.Set<Car>().Add(car);
            }

            base.Seed(context);
        }
    }
}

