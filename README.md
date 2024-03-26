# Animal Shelter API
by Hayeong Pyeon

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Description](#description)
3. [Setup Instructions](#setup-instructions)
4. [Known Bugs](#known-bugs)
5. [License](#license)

## Technologies Used
- C#, .NET
- ASP.NET Core MVC

## Description
- This application is an independent project as a review of **Building an API** chapter of **C#** course provided by Epicodus.
- This API is created for a local animal shelter which provides a list of cats and dogs at the shelter.
- The project objectives are as follows:    
*boxes will be checked upon completion of this project*
> - [ ] Full CRUD functionality.
> - [ ] Further exploration of *versioning*. 
> - [ ] Complete documentation of API endpoints and the further exploration.  

## Setup Instructions
### Precondition
> Make sure you have [MySQL Community Server and Workbench installed](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql). 
> `dotnet-ef` tool is necessary for this project. Install it by running `dotnet tool install --global dotnet-ef --version 6.0.0` in your terminal. 
### How to run the project
1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory named **AnimalShelterApi**. 
3. Within the production directory, create new files called `appsettings.json` and `appsettings.Development.json`.
> [!CAUTION]
> Before pushing commits with the step 4 and 5, you should have a `.gitignore` file in the root directory with the following content:
```
obj
bin
appsettings.json
appsettings.*.json
```
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. 
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
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}
```
5. Within `appsettings.Development.json` file, add the following:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```
6. Run `dotnet ef migrations add [AddEntity]` to create a data migration for the database. *Check out how to name your migration [here](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli).*
> Refer to the following commands when updating, deleting, and viewing migrations. These commands should be made within the production directory. 
> - To **update** the database after making a change, run `dotnet ef database update` in the terminal. 
> - To **remove** the recent update, run `dotnet ef migrations remove` in the terminal. 
> - To **view** the update history, run `dotnet ef migrations list` in the terminal. 
7. Within the production directory, run `dotnet watch run --launch-profile "AnimalShelterApi-Production"` in the command line to start the project in production mode with a watcher.
> To optionally further build out this project in development mode, start the project with `dotnet watch run` in the production directory.
8. Use your program of choice to make API calls. In your API calls, use the domain http://localhost:5000. Keep reading to learn about all of the available endpoints.

## Testing the API Endpoints
This API can be tested with an API platform. Author used [Postman](https://www.postman.com/) while developing. 

### Available Endpoints
*only a format - to be updated*
```
GET http://localhost:5000/api/animals/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```
`{id}` is a variable that should be replaced with the id number of the animal you want to `GET`, `PUT`, or `DELETE`. 

## Known Bugs
*currently under development as of March 25, 2024*

## License
[MIT](/LICENSE.txt) | Copyright © 2024 Hayeong Pyeon