using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data
{
    public class DataContext :DbContext 
    {
        //  se esta creando el constructor de la clase 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                // con este codigo se inyecta
        }
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Lessee> Lessees { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyImage> PropertyImages { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }

    }
}
