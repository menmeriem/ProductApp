# Product App

A simple WinForms application built in C# for managing product inventory.

## Features
- Add new products (name + price)
- View all products in a list
- Search/filter products by name in real time

## Tech Stack
- C# / .NET 8
- WinForms
- In-memory storage (no database)

## Architecture
Follows OOP and SOLID principles with a clean separation of concerns:
- `Models` — Product entity
- `Interfaces` — IProductRepository, IProductService
- `Repositories` — InMemoryProductRepository
- `Services` — ProductService
