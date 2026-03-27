# CrudMvcMySql


- Project: ASP.NET Core Web App (Model-View-Controller)

Name: CrudMvcMySql
Framework: .NET 10.0

- Package Data Base:

MySQL Server
MySQL Workbench

- Query:

CREATE DATABASE crudmvc;

USE crudmvc;

CREATE TABLE Alunos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Email VARCHAR(100)
);

- Package NuGet:

MySql.EntityFrameworkCore