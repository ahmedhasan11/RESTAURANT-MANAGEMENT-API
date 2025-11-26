# 🍽️ Restaurant Management System – Backend

A backend system for managing basic restaurant operations such as menu items, tables, orders, and inventory. This project is built using ASP.NET Core, Clean Architecture, Entity Framework Core, and SQL Server.

## Project Overview
This system provides REST APIs that allow restaurant staff to:
- Manage Menu Items (create, edit, list)
- Manage Tables and update their status
- Create Orders with multiple items
- Automatically update the Inventory
- Authenticate using JWT (Admin / Staff)

## Tech Stack
- ASP.NET Core Web API
- Clean Architecture
- Entity Framework Core (SQL Server)
- JWT Authentication
- Swagger / OpenAPI

## Project Structure
Restaurant.Domain  
Restaurant.Application  
Restaurant.Infrastructure  
Restaurant.Api  

## Getting Started
1. Update appsettings.Development.json with:
   - SQL connection string
   - JWT secret, issuer, audience
2. Run database migrations:
   dotnet ef database update
3. Run the API:
   dotnet run --project Restaurant.Api

Swagger UI will be available at:
https://localhost:<port>/swagger

## Main API Endpoints
POST /api/auth/login  
GET /api/menu  
POST /api/menu  
GET /api/tables  
POST /api/orders  
GET /api/inventory  

## Git Workflow
Using Feature Branching:
main  
 └── feature/<feature-name>

## Notes
This project is for learning and internship purposes. More features can be added later.