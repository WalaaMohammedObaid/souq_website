# Souq – E-Commerce Website with Admin Panel

A full-stack e-commerce (online marketplace) web application built with **ASP.NET**, consisting of a customer-facing storefront and a separate **Admin Panel** for managing the platform.

## Overview

Souq lets customers browse products and shop online, while administrators manage the store through a dedicated admin web application. The solution is organized into two web projects inside a single Visual Studio solution (`souq.sln`), keeping the public storefront and the back-office management cleanly separated.

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Framework | ASP.NET (C#) |
| Architecture | Multi-project Visual Studio solution |
| Frontend | Razor Views, HTML, CSS, JavaScript |
| Data Access | Entity Framework |
| IDE | Visual Studio |

> Update this table with the exact .NET version, database, and libraries used in the project.

## Project Structure

```
souq_website/
├── souq/                      # Customer-facing storefront
├── AdminPanel/
│   └── AdminPanel.Web/        # Admin dashboard for managing the store
└── souq.sln                   # Visual Studio solution
```

## Key Features

**Storefront**
- Browse and search products
- Shopping cart and order placement
- User registration and login

**Admin Panel**
- Manage products and categories
- Manage orders and customers
- Secure, separate administration interface

> Edit these lists to match the features you actually implemented.

## Getting Started

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) with the ASP.NET workload
- [.NET SDK](https://dotnet.microsoft.com/download)
- SQL Server (or the database used by the project)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/WalaaMohammedObaid/souq_website.git
   cd souq_website
   ```

2. **Open the solution**

   Open `souq.sln` in Visual Studio.

3. **Configure the database**

   Update the connection string in each project's `appsettings.json` (or `Web.config`), then apply migrations:
   ```bash
   dotnet ef database update
   ```

4. **Run the projects**

   Set `souq` and `AdminPanel.Web` as startup projects (Multiple Startup Projects), then press **F5**.

## Author

**Walaa Mohammed Obaid**
GitHub: [@WalaaMohammedObaid](https://github.com/WalaaMohammedObaid)
