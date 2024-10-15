build:
	dotnet build

run:
	dotnet run --project Presentation/Presentation.csproj

# Database
db-build:
	docker-compose build postgres

# Command to raise the db container
db-up:
	docker-compose up postgres -d

# Command to stop the db container
db-down:
	docker-compose down postgres

# Command to remove the db container
db-remove:
	docker-compose rm postgres

# Command to create the database
add-migration:
	dotnet ef migrations add Migrations -p Infrastructure/Infrastructure.csproj -s Presentation/Presentation.csproj	

# Command to update the database
migrate:
	dotnet ef database update -p Infrastructure/Infrastructure.csproj -s Presentation/Presentation.csproj
