// file: Attendance.Presentation/TESTING.md

# Presentation Layer — Testing Plan

This file describes a comprehensive testing plan for the Presentation layer and how it integrates with service and infrastructure layers. It covers Unit Tests, Integration Tests, and User Acceptance Tests (UAT). Use this plan to create automated tests and manual test cases.

---

## Scope

- Unit tests for presentation helpers, view models, and small UI logic classes.
- Integration tests for service + repository + EF Core interactions (in-memory or SQLite in-memory).
- Manual UAT for full user workflows through the Presentation UI (Admin, Teacher, Student).

---

## Tools & Frameworks (recommended)

- Unit test framework: `xUnit` (or `NUnit` / `MSTest`)
- Mocking: `Moq` or `NSubstitute`
- EF Core provider for tests: `Microsoft.EntityFrameworkCore.InMemory` or `Microsoft.Data.Sqlite` (in-memory)
- UI automation (optional): `WinAppDriver` or `FlaUI` for automated UI flows
- Test runner / CI: `dotnet test` and GitHub Actions

---

## Test Data & Seed

- Use consistent seed data for automated tests. Example accounts (for testing only):
  - Username: `admin` — Role: Admin — Password: `123456`
  - Username: `teacher1` — Role: Teacher — Password: `123456`
  - Username: `student1` — Role: Student — Password: `123456`
- Seed classes, teachers, and students for deterministic results.
- For integration tests using EF Core InMemory, seed the context within the test setup. For SQLite in-memory, apply migrations and seed before each test run.

---

## 1. Unit Tests

Focus: small, isolated units of code. Mock external dependencies.

Examples to cover:
- `LoginForm` view model / helper:
  - Valid credentials calls authentication service.
  - Invalid credentials show proper error state.
  - Input validation (empty username/password).
- `Preference.cs`:
  - Save/load preference scenarios.
  - Default values used when preferences missing.
- Presentation helpers (formatting, converters):
  - Date formatting, status mapping (Present/Absent/Late).
- Service layer unit tests (in service project):
  - `AttendanceService.MarkAttendance` enforces business rules (only teacher can record).
  - `UserService.Authenticate` returns expected role and fails on wrong password.

Test structure:
- Arrange / Act / Assert
- Use mocking for repositories and external services.
- Keep each test small and focused.

Commands:
- `dotnet test ./tests/` (or solution root)

---

## 2. Integration Tests

Focus: multiple layers working together (Service + Infrastructure + EF Core).

Approaches:
- EF Core InMemory provider:
  - Fast, suitable for repository and service tests.
  - Seed test data in test setup.
- SQLite in-memory with migrations:
  - Closer to production relational behavior (constraints, SQL).
  - Apply migrations at test startup.

Example integration test cases:
- Repository CRUD:
  - Create Student -> Read by Id -> Update -> Delete -> Validate DB state.
- Attendance flow:
  - Seed teacher, class, student.
  - Teacher marks attendance for a date.
  - Verify `AttendanceRecord` persisted with correct `RecordedBy` and `Status`.
- Authentication + Authorization:
  - Authenticate teacher and attempt to mark attendance -> success.
  - Authenticate student and attempt to mark attendance -> rejected.

Test lifecycle:
- Initialize fresh DB or provider per test (or per test class).
- Clean up resources after tests.

Sample setup (pseudo):
- Use a test fixture that creates DbContextOptions for InMemory or SQLite.
- Use real `Repository` and `Service` instances wired to the test context.

---

## 3. End-to-End / UI Integration Tests (Optional Automated)

Focus: automated flows that exercise the Presentation UI and backend.

Tools:
- `WinAppDriver` or `FlaUI` to automate WinForms interactions.
- Or, use manual UAT if automation is not available.

Automated UI scenarios:
- Login as `teacher` -> navigate to class -> mark attendance -> confirm success message.
- Login as `admin` -> create a new user -> verify created in DB.
- Login as `student` -> view attendance records -> verify attendance entries present.

Notes:
- UI automation can be brittle; prefer to keep logic in testable non-UI components and test those separately.

---

## 4. User Acceptance Tests (UAT) — Manual Checklist

Perform these tests on a deployed or local build with Presentation project as startup.

Common preconditions:
- Use seed accounts above.
- DB has sample classes and students.

UAT scenarios (pass/fail criteria included):

1. Login
   - Input: valid credentials for each role.
   - Expected: login success, correct dashboard shown.
2. Admin: User management
   - Add user -> Verify user in list and in DB.
   - Edit user role -> Verify role change takes effect.
3. Teacher: Marking attendance
   - Navigate to class -> Select date -> Mark students Present/Absent.
   - Expected: attendance saved and visible in reports.
4. Student: Viewing attendance
   - Login as student -> View personal attendance -> Ensure data matches records.
5. Reports & Export
   - Generate attendance report for a class/date range.
   - Export CSV/PDF (if available) -> Verify file contents match displayed data.
6. Error handling
   - Attempt invalid operations (e.g., student trying to mark attendance) -> UI should show authorization error.
7. Persistence
   - Restart app -> data persists in DB.

Record:
- Steps performed, inputs, expected vs actual, screenshots, and log files for failures.
- Acceptance criteria: all critical flows pass; no showstopper bugs.

---

## Test Cases / Matrix (example entries)

- Login: valid admin -> dashboard loads (Pass/Fail)
- Login: invalid password -> error message (Pass/Fail)
- Attendance: teacher marks present -> record created (Pass/Fail)
- Authorization: student attempts mark -> operation denied (Pass/Fail)
- Report: export CSV -> file contains header + rows (Pass/Fail)

---

## CI & Automation

- Add `dotnet test` to CI workflow.
- Use separate job/step that runs integration tests with an in-memory DB or a clean SQLite DB.
- If UI tests are added, run them on a runner capable of UI automation or a self-hosted runner.

Example GitHub Actions steps:
- Checkout, setup .NET 9, run `dotnet restore`, `dotnet build`, `dotnet test`.

---

## Test Quality & Maintenance

- Keep tests deterministic and independent.
- Run fast unit tests on every commit; run longer integration tests nightly or on PR.
- Review flaky tests and stabilize before merging PRs.
- Ensure test data seeding is idempotent.

---

## How to Run (summary)

- Unit tests: `dotnet test` (solution root or tests project)
- Integration tests (InMemory): `dotnet test` — tests should configure in-memory DB in their fixtures
- UI tests (if present): follow the test project's README for driver setup (WinAppDriver/FlaUI)

---

## Related Files

- See `../README.md` for overall project architecture and database configuration.
- See `Attendance.Presentation/README.md` for presentation-specific docs and how to run the app.

---