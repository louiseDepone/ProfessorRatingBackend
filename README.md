# .NET Web API with PostgreSQL Backend

This project is a .NET Web API backend that connects to a PostgreSQL database. It is designed to work alongside a separate React.js frontend repository (RateToFive).

## Features
- .NET 9 Web API
- PostgreSQL database integration
- RESTful API endpoints
- Authentication & Authorization
- CRUD operations
- Supports connection to a React.js frontend

## Prerequisites
Ensure you have the following installed:
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/)
- [Node.js & npm](https://nodejs.org/) (for React frontend)

## Setup Instructions

### 1. Clone the repository
```bash
git clone 
cd 
```

### 2. Configure the Database
1. Create a PostgreSQL database.
2. Update the connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=your_db;Username=your_user;Password=your_password"
}
```

### 3. Apply Migrations
Run the following commands to set up the database schema:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the API
Start the Web API using:
```bash
dotnet run
```
```


