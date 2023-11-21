# C# Docker Exercise 1

## Learning Objectives  

- Deploy an application to a Docker Container  

## Instructions  

1. Fork this repository  
2. Clone the fork to your machine  
3. Open in Visual Studio  

## Introduction  

In this exercise you will be Dockerizing a small website to manage the Boolean Products. The app lists/adds/deletes products using a static list.

## Core 

- Add the exercise.wwwapp web project to a docker container
- Migrate any code relating to the Product to the database
	- Create a Postgres container locally in Docker and update the appsettings.json to point to this database.   
	- Amend the project accordingly to work with the Postgres Db
	- Install any nuget packages needed
	- Run migrations to populate the database 
	- Ensure you update the `BooleanRepository.cs` as they should write to the new data store via a DbContext.   
	- Remove any legacy that is not used in the `DataStore.cs` 
	- Also seed the current stock somewhere of your choosing.
- Ensure the stock management works with your changes.  Moving this to be database managed is in the extension for this exercise.  
- You shouldn't need to change the Views/Pages in this exercise but feel free to amend where relevant
- Write clean code and comment with XML comments where necessary  


## Extension
- Migrate the Teacher part of the application to the database.  
- Write clean code and comment with XML comments where necessary  

