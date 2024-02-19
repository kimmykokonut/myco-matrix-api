# MycoMatrix

A web API for data on various types of mushrooms, built using .NET6.0 AspNetCore

By Henry Oberholtzer & Kim Robinson

## Technologies Used

- C#
- Swagger/OpenAPI

## Features

## Upcoming Changes
- Add Pagination!

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

### Endpoints
```
GET http://localhost:5000/api/myco/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```

### GET Requests

#### Optional GET Parameters
| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| species     | String      | not required | Returns animals with a matching species value |
| name        | String      | not required | Returns animals with a matching name value |
| minimumAge  | Number      | not required | Returns animals that have an age value that is greater than or equal to the specified minimumAge value |

##### GET Examples

Returns all animals with a species value of "Stegosaurus":
```
GET https://localhost:5000/api/animals?species=stegosaurus
```

Returns

Returns all animals with the name "Lucy"
```
GET https://localhost:5000/api/animals?name=lucy
```
Returns all animals of 10 or older
```
GET https://localhost:5000/api/animals?minimumAge=10
```
Multiple queries can be joined with "&"
```
GET http://localhost:5000/api/animals?species=tyrannosaurus&minimumAge=400
```

### POST Requests
A body is required for a post request, exemplified by the following:
```
{
  "species": "Tyrannosaurus Rex",
  "name": "Lucy",
  "age": 8
}
```
### PUT Requests

A body including the animalId is required, exemplified by the following:
```
{
  "animalId": 14,
  "species": "Tyrannosaurus Rex",
  "name": "Lucy",
  "age": 8
}
```
The PUT request URL corresponds to the animalId of the animal in the body:
```
http://localhost:5000/api/animals/14
```



## License

(c) 2024 [Henry Oberholtzer](https://www.henryoberholtzer.com/) & [Kim Robinson](https://www.github.com/kimmykokonut)

Original code licensed under the [GNU GPLv3](https://www.gnu.org/licenses/gpl-3.0.en.html#license), other code bases and libraries as stated.