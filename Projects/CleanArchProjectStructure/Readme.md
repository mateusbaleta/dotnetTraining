
# 🧱 .NET Clean Architecture Overview & Project Types

## 📐 Clean Architecture Project Structure in .NET

A commonly adopted Clean Architecture setup in .NET projects involves organizing your solution into clear, isolated layers. Each layer focuses on a specific responsibility and only references the ones below it.

---

## 🗂️ Recommended Folder Structure

```
/src
  ├── ProjectName.API                → Presentation layer (Controllers, Middleware)
  ├── ProjectName.Application       → Use Cases, Interfaces, DTOs, CQRS Handlers
  ├── ProjectName.Domain            → Core domain (Entities, Value Objects, Enums)
  ├── ProjectName.Infrastructure    → External services (Email, File, Auth)
  ├── ProjectName.Persistence       → Database access (EF Core, Dapper, Migrations)
  └── ProjectName.Tests             → Unit & Integration Tests

/Shared
  └── ProjectName.Shared            → Cross-cutting utilities (Result<T>, Extensions)
```

---

## 🧩 Layer Responsibilities

### 🔹 Domain

- Core entities  
- Value objects  
- Domain services & events  
- Pure business logic  
- **No dependencies on other projects**

---

### 🔹 Application

- Use case orchestration  
- CQRS (Commands/Queries)  
- DTOs, Validators, Interfaces  
- **Depends only on Domain**

---

### 🔹 Infrastructure

- Third-party integrations  
- Logging, Auth, File I/O, External APIs  
- **Implements interfaces from Application**

---

### 🔹 Persistence

- Data access logic  
- Entity Framework Core / Dapper  
- Repository implementations  

---

### 🔹 API

- ASP.NET Core Web API  
- Controllers, middleware, filters  
- Dependency injection wiring  

---

### 🔹 Tests

- Unit tests  
- Integration tests  
- Test helpers, mock services  

---

## ⚙️ .NET Project Types Explained

When creating .NET projects, choosing the right template is important. Below is a comparison of the most common types:

---

### 1. 🧾 Console Application

```bash
dotnet new console
```

| Value         | Description                |
|---------------|----------------------------|
| Purpose       | Quick apps, CLI tools      |
| Entry Point   | `Main(string[] args)`      |
| Output        | `.exe` / `.dll`            |
| Runs Standalone? | ✅ Yes                  |

> **Good for**: Small tools, test runners, and automation scripts.

---

### 2. 📚 Class Library

```bash
dotnet new classlib
```

| Value         | Description                   |
|---------------|-------------------------------|
| Purpose       | Reusable code modules         |
| Entry Point   | ❌ None                        |
| Output        | `.dll`                        |
| Runs Standalone? | ❌ No                      |

> **Good for**: Domain logic, shared services, reusable components.

---

### 3. 🛠️ Worker Service

```bash
dotnet new worker
```

| Value         | Description                       |
|---------------|-----------------------------------|
| Purpose       | Long-running background jobs      |
| Entry Point   | `BackgroundService` class         |
| Output        | `.exe` / `.dll`                   |
| Runs Standalone? | ✅ Yes                        |

> **Good for**: Queue processing, scheduled tasks, daemons, background services.

---

## ✅ Summary Table

| Project Type     | Standalone? | Entry Point                   | Common Use Cases                                 |
|------------------|-------------|--------------------------------|--------------------------------------------------|
| Console App      | ✅ Yes      | `Main(string[] args)`          | CLI tools, quick scripts                         |
| Class Library    | ❌ No       | None                           | Shared logic, domain, utilities                  |
| Worker Service   | ✅ Yes      | `Worker : BackgroundService`   | Background jobs, queue processing, daemons       |

---

## 🧪 Bonus Tips

- Use **MediatR** in the `Application` layer for clean CQRS handling.
- Keep your `Domain` project **pure**—no references to infrastructure.
- Configure all dependencies in the `API` project.
- Host your `Worker` project as a **Windows service** or **systemd** on Linux.
