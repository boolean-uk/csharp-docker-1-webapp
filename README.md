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

## Extension

- Create a Postgres container locally and update the application to point to this database. Populate the database with the current products and add some more if you wish.
- Add a Product model, install any nuget packages needed, run migrations to populate the database.
- Update the `ProductInventory.cs` methods Create/Read/Delete as they should write to the new data store via a DbContext.
- Write clean code and comment with XML comments where necessary
- Remove any legacy code



