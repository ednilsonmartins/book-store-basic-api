# BookStore

BookStore is an ASP.NET Core Web API project for managing books. This project follows Domain-Driven Design (DDD) principles.


## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Compose](https://docs.docker.com/compose/install/)


## Architecture Details

The project follows a layered architecture pattern, which separates the concerns into different layers. Here is a brief description of each layer:

1. `Presentation Layer` => `Presentation`: This layer contains the ASP.NET Core Web API controllers and is responsible for handling HTTP requests and returning responses.

2. `Application Layer` => `Application`: This layer contains the application services that orchestrate the business logic. It acts as a bridge between the presentation layer and the domain layer.

3. `Domain Layer` => `Domain`: This layer contains the domain entities, and business logic. It represents the core of the application and is independent of any infrastructure concerns.

4. `Infrastructure Layer` => `Infrastructure`: This layer contains the implementation of infrastructure concerns such as data access. It includes repositories, data access objects, and other infrastructure-related components.


## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/yourusername/BooksAI.git
cd BookStore
```

2. Restore the dependencies:
```bash
dotnet restore
```

## Building the Project
To build the project, run the following command:
```bash
dotnet build
```
or
```bash
make build
```

## Running the Project
To run the project, run the following command:
```bash
make run
```
or
```bash
dotnet run --project Presentation/Presentation.csproj
```

## Browse the API
Once the project is running, you can browse the API by navigating to the following URL in your web browser:
```
https://localhost:5001/swagger
```
** Remember to apply the migrations before using the API!

## Database Management
### Building the Database Container
To build the database container, run the following command:
```bash
make db-build
```

### Starting the Database Container
To start the database container, run the following command:
```bash
make db-up
```

### Stopping the Database Container
To stop the database container, run the following command:
```bash
make db-down
```

### Removing the Database Container
To remove the database container, run the following command:
```bash
make db-remove
```

### Adding a Migration
To add a migration, run the following command:
```bash
make add-migration
```

### Applying Migrations
To apply migrations, run the following command:
```bash
make migrate
```
