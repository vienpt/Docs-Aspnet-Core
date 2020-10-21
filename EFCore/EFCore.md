# Entity Framework Core

## Connecting to Database

### DBContext

- What is DBContext
- Connect to the database
- Query & updating the database
- Hold the information needed to configure the database

### Connection String

- Configuration appsettings.json
- Passing connection string to DBContext
- Reading the connection string

## Configuring the model

### Using Code First conventions

## Config using data annotation

### Table Attribute

### Column Attribute

### Key Attribute

### ComplexType Attribute

### ConcurrencyCheck Attribute

### Timestamp Attribute

### Databasegenerated Attribute

### ForeignKey Attribute

### MaxLength Attribute

### StringLength Attribute

### NotMapped Attribute

### Required Attribute

### InverseProperty Attribute

## What is EF Core

### That is Microsofts implementation of ORM Framework

ORM is an Object-Relational mapper. That is a code library that automates the transfer of data stored in relational database tables into objects.

- What is ORM

	- ORM (Object-Relational-Mapper) is a code library that automates the transfer of data stored in relational database tables into objects.

### The applications created using the EF doesn't work with the database directly

### The applications works only with the API provided by the EF for database related operations

### The EF maps those operations to the database

## Config using Fluent API

### Fluent API

### Ignore Method

### HasAlternateKey

### EntityType Configuration

## Config the relationships

### Relationships & Navigational Properties

### 1-to-1 relationships

### 1-to-N relationships

### N-to-N relationships

## Querying

### First, FirstOrDefault, Single, SingleOrDefault

### Find

### Projection

### Join

### Eager loading

- Include
- ThenInclude

### SelectMany

### Explicit loading

### Lazy loading

## Persisting the data

### Save changes

### ChangeTracker, EntityEntry, Entity States

### Add Records/Multiple Records

### Update Record

### Delete Record

### Cascade Delete

## Migrations

### Migrations

### Database first

### Data Seeding

### Script

## Logging

*XMind: ZEN - Trial Version*