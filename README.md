# MycoMatrix

A web API for data on various types of mushrooms, built using .NET6.0 AspNetCore

By Henry Oberholtzer & Kim Robinson

## Technologies Used

- C#
- Swagger/OpenAPI

## Features
- user can access API with GET (all), GET (by id), POST, DELETE (by id), PUT and PATCH (by id)
- user can read and create, but can only edit/delete objects if they are the listed editor
- GET all includes query parameters, some are keyword enabled (not exact match)
- Pagination included in GET (all) request
- JWT Token added for authentication (user can register and sign in for token, use Bearer token to call API)
- Version 1 & 2 set up.

## Upcoming Changes
* Object within object?
* API key

## Setup/Installation Requirements

- .NET 6 or greater is required for set up, and dotnet-ef to manage migrations.
- To establish locally, [download the repository](https://github.com/henry-oberholtzer/MessageBoard/archive/refs/heads/main.zip) to your computer.
- Open the folder with your terminal and run `dotnet restore` to gather necessary resources.
- For security, the appsettings.json file has been left out of the project, and will need to be created.
- In the production direction, `/CretaceousApi` run `$ touch appsettings.json`
- In `appsettings.json`, enter the following, replacing `USERNAME` and `PASSWORD` to match the settings of your local MySQL server.
  
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=cretaceous_api;uid=USERNAME;pwd=PASSWORD;"
  }
}
```
- A local instance of MySQL (8.0.0 or greater) is required to be set up and running to use the project, for information on installing and configuring MySQL, [please see the official documentation.](https://dev.mysql.com/doc/mysql-installation-excerpt/8.3/en/)
- If you do not have `dotnet-ef` installed, first install it by running `dotnet tool install --global dotnet-ef --version 6.0.0`
- Run `dotnet ef database update` to create the database based on the provided database migrations.
- To start the projet, in the production directory, run the command `dotnet run` on your terminal.

## Known Bugs

- None at this time

# API Documentation

Full CRUD support is provided. Please see the [the documentation]()
<!-- README thoroughly describes the further exploration topic that's been implemented in the API. -->

## License

(c) 2024 [Henry Oberholtzer](https://www.henryoberholtzer.com/) & [Kim Robinson](https://www.github.com/kimmykokonut)

Original code licensed under the [GNU GPLv3](https://www.gnu.org/licenses/gpl-3.0.en.html#license), other code bases and libraries as stated.