# Animal Shelter API 🐕🐈🏠
by Hayeong Pyeon

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Description](#description)
3. [Setup Instructions](#setup-instructions)
4. [Testing API Endpoints](#testing-the-api-endpoints)
5. [Further Exploration](#further-exploration-versioning)
4. [Known Bugs](#known-bugs)
5. [License](#license)

## Technologies Used
- C#, .NET
- ASP.NET Core MVC
- MySQL
- Entity Framework Core
- Swagger 
- Postman 

## Description
- This application is an independent project as a review of **Building an API** chapter of **C#** course provided by Epicodus.
- This API is created for a local animal shelter which provides a list of cats and dogs at the shelter.
- The project objectives are as follows:    
> - [x] Full CRUD functionality.
> - [x] Further exploration - *versioning*.
> - [x] Complete documentation of API endpoints and the further exploration.  
- For another further exploration objective, the frontend MVC application that consumes this API is build and uploaded in this [repo](https://github.com/hypyeon/epicodus-project16-animal-shelter-client).

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
```
GET http://localhost:5000/api/v1/dogs/
GET http://localhost:5000/api/v1/dogs/{id}
POST http://localhost:5000/api/v1/dogs/
PUT http://localhost:5000/api/v1/dogs/{id}
DELETE http://localhost:5000/api/v1/dogs/{id}
```
`{id}` is a variable that should be replaced with the id number of the animal you want to `GET`, `PUT`, or `DELETE`. 

#### Optional Query String Parameters for GET Request
GET requests to `http://localhost:5000/api/v1/dogs/` can optionally include query strings to filter or search dogs.
> The following query will return all dogs with a sex value of **Female**. 
```
GET http://localhost:5000/api/v1/dogs?sex=female
```
> The following query will return all dogs with a neuteredSpayed value of **true**.
```
GET http://localhost:5000/api/v1/dogs?neuteredSpayed=true
```

#### Additional Requirements for POST Request
When making a POST request to `http://localhost:5000/api/v1/dogs/`, you need to include a **body**. Here's an example body in JSON:
```
{
  "name": "Buddy",
  "breed": "German Shepherd",
  "sex": "Male",
  "age": "1 year (estimate)",
  "neuteredSpayed": true
}
```
#### Additional Requirements for PUT Request
When making a PUT request to `http://localhost:5000/api/v1/dogs/{id}`, you need to include a body that includes the dog's dogId property. Here's an example body in JSON:
```
{
  "dogId": 1,
  "name": "Rosy",
  "breed": "Chihuahua",
  "sex": "Female",
  "age": "3 weeks",
  "neuteredSpayed": false
}
```
And here's the PUT request we would send the previous body to:
```
http://localhost:5000/api/v1/dogs/3
```
The value of `dogId` needs to match the id number in the URL. (In this example, they are both `3`.)

## Further Exploration: Versioning
API versioning is a technique used to manage changes in the API over time. It allows developers to introduce new features, modify existing ones, or deprecate certain functionalities without breaking existing client applications.
- To specify the API version in the URL, use the following format (replace `{version}` with the desired version number):
```
http://localhost:5000/api/v{version}/dogs
```
### Additional Information
- The default API version is set to 1.0 that will be used when no version is specified. (Currently only v1 is available)
- API responses will include information about the API version used.
- More info about `API versioning` can be found [here](https://christian-schou.dk/blog/how-to-use-api-versioning-in-net-core-web-api/).

## Known Bugs
No bug found as of March 26, 2024. [Reach out](mailto:hayeong.pyeon@gmail.com) if found any.

## License
[MIT](/LICENSE.txt) | Copyright © 2024 Hayeong Pyeon