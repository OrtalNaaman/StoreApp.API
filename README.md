## UCG- Unique Clothes for Girls - Web API 
- RESTful API for user & products management.
- CRUD oprations.

## Table of Contents

- [Features](#features)
- [API Access](#api-access)
- [Installation](#installation)



## Features:
- SQL Database with Entity Framework Code First.
- Data is seeded on installation.
- LINQ Queries.
- Usage of AutoMapper & DTO's.
- JWT Authentication & Identity Core.
- Authorization: 3 user roles - ["Guest", "User", "Admin"].



## API Access
| User              | Password                   | Access       |  Access & Abilities           |        
| :---------------  | :------------------------- | :----------- | :-----------
| admin@email.com   | Aa@1234                    | Administrator|  Full access to any page in the app |
| admin@email.com   | Aa@1234                    | Administrator|  Full access to any page in the app |
| admin@email.com   | Aa@1234                    | Administrator|  Full access to any page in the app |


## Installation

To install the UCG API, follow these steps:
- Clone the repository to your local machine using the following command:
```bash
git clone https://github.com/OrtalNaaman/StoreApp.API
```
- Create a new Microsoft SQL Server database to store the application data.
- Open the file appsettings.json located in the UCG project folder and modify the following connection string with your own Microsoft SQL Server database connection string:
```bash
"ConnectionStrings": {
  "ConnectionString": "Server=<your-server-name>;Database=MyStoreDB;Trusted_Connection = True;TrustServerCertificate= True;"
}
```

- Open the file secrets.json located in the StoreApp.API project folder and set the following key:
```bash
"Keys": {
"Key": "this is my amazing very Secret key for authentication"
}
```


- Open the Package Manager Console in Visual Studio, select the StoreApp.API.Data project, and run the following command to create the database schema:
```bash
update-database
```

- Run the project in Visual Studio, The API server should now be running on your local machine & you should see Swagger Api Documentation.
- User Registration: - User must register himself by filling some personal details.
- User Login: After registration user will enter Email and password for logging in order to get access to the system.
- Personal: User can edit personal details, Admininstrator can edit/delete all users details.
