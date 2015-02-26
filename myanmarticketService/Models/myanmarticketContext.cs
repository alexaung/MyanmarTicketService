using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using myanmarticketService.DataObjects;
using myanmarticketService.DataObjects.BusTicket;

namespace myanmarticketService.Models
{
    public class myanmarticketContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        //
        // To enable Entity Framework migrations in the cloud, please ensure that the 
        // service name, set by the 'MS_MobileServiceName' AppSettings in the local 
        // Web.config, is the same as the service name when hosted in Azure.
        private const string connectionStringName = "Name=MS_TableConnectionString";

        public myanmarticketContext() : base(connectionStringName)
        {
        } 

        
        public DbSet<AirPort> AirPorts { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        public DbSet<Personal> Personals { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<BusType> BusTypes { get; set; }

        public DbSet<ServiceProvider> ServiceProviders { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<BusImage> BusImages { get; set; }

        public DbSet<BusStation> BusStations { get; set; }

        public DbSet<BusSchedule> BusSchedules { get; set; }

        public DbSet<BusRoute> BusRoute { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            string schema = ServiceSettingsDictionary.GetSchemaName();
            if (!string.IsNullOrEmpty(schema))
            {
                modelBuilder.HasDefaultSchema(schema);
            }

            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }        
    }

}
