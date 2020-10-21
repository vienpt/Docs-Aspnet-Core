using System;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    // Our EFContext class inherits from the DBContext class
    public class EFContext : DbContext
    {
        // Next, we have defined our connection string.
        private const string connectionString = "Server=127.0.0.1,1433;User=SA;Password=P@ssw0rd;Database=EFCore;";


        /*
        The OnConfiguring method allows us the configure the DBContext.
        An instance of the DbContextOptionsBuilder is passed as the argument to the OnConfiguring method.
        The DbContextOptionsBuilder provides API to configure the DBContext.
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
             We call the UseSQLServer extension method provided by the Microsoft.EntityFrameworkCore.SqlServer
             The UseSqlServer method sets SQL Server as our database provider.
             It takes the connection string as its argument.
             */
            optionsBuilder.UseSqlServer(connectionString);
        }

        /*
        we use the DbSet property for the entity class Product.
        A DbSet represents an entity set.
        An entity set is defined as a set of entities of the same entity type.
        From the perspective of the database, it usually represents the table.

        Each Entity type must expose the DbSet Property to be able to participate in the CRUD Operations.
        DBSet Provides methods like Add, Attach, remove etc on the Entity Types.
         */

        public DbSet<Product> Products { get; set; }
    }
}
