# EFCore

## step by step to create new EF Core for project

1. [] Add package “Microsoft.EntityFrameworkCore.SqlServer”
2. [] Create new Entity class
3. [] Create the DBContext class
4. [] Create the database
      Run command: `dotnet ef migrations add "new database"`
                   `dotnet ef databse update`
5. [] CRUD Operations

5.1 [] Inserting Data
    // Inserting to the database is handled by the SaveChanges method of the DBContext object.

5.2 [] Querying the Data
    // The queries are written against the Dbset property of the entity.
    // The queries are written using the LINQ to Entities API.
    // There are two ways in which you can write queries in LINQ.
    //      One is method syntax & the other one is Query Syntax.

5.3 [] Update the Record
    // we use the find method to retrieve the single Product
    // The find method takes the id (primary key) of the product as the argument
    //  and retrieves the product from the database, and maps it into the Product entity.

5.4 [] Delete the Record
    // Deleting is done using the Remove method of the DbSet
    // We need to pass the entity to delete as the argument to the remove
