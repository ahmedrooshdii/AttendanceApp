// file: Attendance.Presentation/README.md

# Attendance Management System — Presentation Layer

## Project Overview

The Attendance Management System (ASMS) is a multi-layer .NET 9 application to manage users (Admin, Teacher, Student), classes, and attendance records. This repository uses a clean layered architecture separated into Domain, Infrastructure, Service, and Presentation projects.

This README documents the Presentation layer specifically and gives full project-level details, setup, and testing instructions.

---

## Technology Stack

- .NET 9 (target framework)
- C#
- Entity Framework Core (EF Core) for data access
- SQL Server (default) — configurable via connection string
- xUnit / NUnit / MSTest for unit tests (project test framework may vary)
- Windows Forms or WinUI (Presentation layer uses Windows Forms by convention in this solution)

---

## Solution & Project Layout

Root solution (F:\Repos\ASMS)
- `Attendance.Domain/` — domain entities, value objects, enums, validations
- `Attendance.Infrastructure/` — EF Core DbContext, migrations, repositories
- `Attendance.Service/` — application services, business rules, DTOs
- `Attendance.Presentation/` — UI layer (Windows Forms), app configuration, entry point

Presentation project structure (this folder)
- `Attendance.Presentation/`
  - `Forms/` — UI forms (LoginForm, Dashboards, Attendance forms)
  - `Resources/` — images, icons, localized strings
  - `Program.cs` — application entry point and host setup
  - `appsettings.json` — configuration (connection string, logging)
  - `README.md` — this file
  - `TESTING.md` — UI & presentation testing plans

---

## Key Domain Models & Database Tables

(These entities live in `Attendance.Domain` and map to tables via EF Core in `Attendance.Infrastructure`.)

- `User`
  - `Id` (GUID/int)
  - `Username` (string, unique)
  - `PasswordHash` (string) — do NOT store plain text in production
  - `Role` (enum: Admin, Teacher, Student)
  - `Email`, `CreatedAt`, `IsActive`

- `Student`
  - `Id`
  - `UserId` (FK to User)
  - `FullName`
  - `Email`
  - `ClassId` (FK)

- `Teacher`
  - `Id`
  - `UserId` (FK to User)
  - `FullName`
  - `Email`
  - `Subject`

- `Class` (or `Course`)
  - `Id`
  - `Name`
  - `TeacherId` (FK)

- `AttendanceRecord`
  - `Id`
  - `StudentId` (FK)
  - `Date` (date)
  - `Status` (enum: Present, Absent, Late)
  - `RecordedBy` (UserId of teacher/admin)

Migrations and DB schema are maintained in `Attendance.Infrastructure`.

---

## Authentication & Roles

- Roles: `Admin`, `Teacher`, `Student`.
- Authentication: simple username/password based login. For testing only, sample accounts use password `123456`. In production replace with hashed/salted passwords and secure identity provider.
- Authorization: UI and service methods restrict actions by role (e.g., only teachers record attendance, admin manages users).

Test accounts (default for local testing)
- Username: `admin` — Role: Admin — Password: `123456`
- Username: `teacher` — Role: Teacher — Password: `123456`
- Username: `student` — Role: Student — Password: `123456`

(If you seed users in migrations or a dev seeder, adjust accordingly. Never use these credentials in production.)

---

## Configuration

- Edit `appsettings.json` in the startup project (`Attendance.Presentation`) to set the database connection string and logging settings.
- Default expectation: SQL Server connection string. Example:
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ASMS;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
  }

---

## Setup & Run (Development)

Prerequisites:
- .NET 9 SDK installed
- Visual Studio 2022 (17.x) or VS Code with C# extensions
- (Optional) `dotnet-ef` CLI for migrations: `dotnet tool install --global dotnet-ef`

1. Clone repository and open solution in IDE:
   - Solution path: `F:\Repos\ASMS\ASMS.sln` (or open the folder)

2. Restore packages:
   - `dotnet restore` (run in solution root)

3. Apply EF Core migrations (run from solution root or from `Attendance.Infrastructure` project):
   - `dotnet ef database update --project .\Attendance.Infrastructure\Attendance.Infrastructure.csproj --startup-project .\Attendance.Presentation\Attendance.Presentation.csproj`
   - If you have no migrations yet:
     - `dotnet ef migrations add InitialCreate --project .\Attendance.Infrastructure\Attendance.Infrastructure.csproj --startup-project .\Attendance.Presentation\Attendance.Presentation.csproj`
     - then `dotnet ef database update ...`

4. Set startup project:
   - In Visual Studio, set `Attendance.Presentation` as startup and run (F5), or run:
   - `dotnet run --project .\Attendance.Presentation\Attendance.Presentation.csproj`

---

## Running Tests

- Unit and integration tests are kept in a test project (if present in this solution). Typical commands:
  - `dotnet test` (from solution root) — runs all tests.
- For integration tests that use a database, tests should use an in-memory provider or a test database and apply migrations before running.

See `TESTING.md` in this folder for the presentation layer test checklist and manual UAT steps.

---

## Presentation Layer Responsibilities

- UI flow and navigation (Login → Dashboard → Attendance)
- Input validation (basic client-side checks)
- Calling service layer APIs for business operations
- Rendering lists, reports, and modals for user interactions
- Local caching of preferences (e.g., `Preference.cs`)

Files you will commonly edit here:
- `Forms/LoginForm.cs` — login logic
- `Forms/AdminDashboardForm.cs` — admin UI
- `Forms/TeacherDashboardForm.cs` — teacher UI
- `Forms/StudentDashboardForm.cs` — student UI
- `Program.cs` — DI container & service registration for Presentation startup

---

## Testing Plan (summary)

- Unit tests: service logic, validation helpers, and small UI logic classes (view models).
- Integration tests: repository methods against an in-memory or test SQL DB; end-to-end flows (login, mark attendance).
- Manual/UAT: verify role-based UI, report correctness, and error handling.

For a step-by-step plan and test cases, see `Attendance.Presentation/TESTING.md` and the solution-level `TESTING.md` if present.

---

## Contributing

    This folder contains the Presentation Layer of the Attendance Management System built with .NET 9. It provides the user interface and handles user interactions for Admin, Teacher, and Student roles.

---

## Folder Structure
