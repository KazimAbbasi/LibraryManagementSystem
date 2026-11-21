# Library Management System

A desktop application built with **C#, Windows Forms, and SQL Server** for managing books, student records, and library borrowing operations.

## About the Project

I completed this project while learning C#, bringing interface development, event-driven programming, and database operations together in a working desktop application.

The application connects a Windows Forms interface with C# application logic and a SQL Server database. A central dashboard provides access to book management, student records, issuing books, returns, and borrowing history.

## Application Preview

<img width="900" alt="Library Management System dashboard" src="https://github.com/user-attachments/assets/8ddbfe54-e4e9-4bfb-b54f-be1ab4d9dc3c" />

*The application's main dashboard.*

## Features

### Book Management

- Add books with their title, author, publisher, publication date, price, and quantity.
- Display book records in a table.
- Search books by title.
- Update existing book information.
- Delete book records with confirmation.

### Student Management

- Register students with enrollment number, department, semester, contact number, and email.
- View and search student records.
- Update student information.
- Delete student records with confirmation.

### Book Issuing

- Find registered students by enrollment number.
- Select a book and record its issue date.
- Check outstanding borrowing counts before issuing a book.

### Book Returns

- Retrieve a student’s outstanding loans.
- Select a borrowing record and save its return date.
- Preserve the record for borrowing history.

### Borrowing Records

- View currently issued books.
- View returned books separately.
- Review the student and book information associated with each loan.

### Login

- Check login credentials against the database.
- Display feedback for unsuccessful login attempts.

## Technology Stack

| Technology | Purpose |
| --- | --- |
| C# | Application logic and event handling |
| .NET 10 for Windows | Application framework |
| Windows Forms | Desktop user interface |
| SQL Server LocalDB | Database storage |
| ADO.NET | Database commands and data retrieval |
| Microsoft.Data.SqlClient | SQL Server connectivity |
| DataGridView | Displaying and selecting records |

## Example Workflow

1. Sign in to the application.
2. Add books to the library records.
3. Register a student.
4. Open **Issue Books**, find the student, and issue a selected book.
5. Open **Return Books** to retrieve the loan and record its return.
6. Open **Complete Book Details** to review issued and returned books.

## Repository Structure

| Item | Purpose |
| --- | --- |
| `LibraryManagemwntGUI.slnx` | Visual Studio solution |
| `LibraryManagemwntGUI/` | Application source, project file, forms, and resources |
| `SQLQuery3.sql` | Database table definitions and demo login setup |
| `README.md` | Project documentation |

The spelling `LibraryManagemwntGUI` matches the project’s existing folder and file names.

### Main Forms

| File | Responsibility |
| --- | --- |
| `Form1.cs` | Login |
| `Dashboard.cs` | Main navigation |
| `AddBooks.cs` | Adding books |
| `ViewBook.cs` | Viewing, searching, updating, and deleting books |
| `AddStudent.cs` | Registering students |
| `ViewStudentInformation.cs` | Viewing and managing student records |
| `IssueBooks.cs` | Issuing books |
| `ReturnBook.cs` | Recording returns |
| `CompleteBookDetails.cs` | Viewing issued and returned records |

Forms also include associated `.Designer.cs` and `.resx` files for layout and resources.

## Database

The application uses a SQL Server database named **`library`**.

| Table | Stored Information |
| --- | --- |
| `loginTable` | Login credentials |
| `NewBook` | Book details |
| `NewStudent` | Student records |
| `IRBook` | Borrowing records, issue dates, and return dates |

In `IRBook`, a `NULL` return date identifies an outstanding loan. A populated return date identifies a returned book.

## Getting Started

### Requirements

- Windows.
- .NET 10 SDK.
- Visual Studio with the **.NET desktop development** workload and support for .NET 10.
- SQL Server Express LocalDB.
- A SQL query tool, such as Visual Studio’s SQL Server Object Explorer or SQL Server Management Studio.

### 1. Download the Project

Clone the repository or select **Code → Download ZIP**, then extract the downloaded archive.

### 2. Create the Database

Connect to the following SQL Server instance:

```text
(localdb)\MSSQLLocalDB
```

Run this query to create a fresh database:

```sql
CREATE DATABASE library;
GO

USE library;
GO
```

Open **`SQLQuery3.sql`** and execute its contents against the `library` database.

The script creates the required tables and inserts the demonstration login account.

> Run the setup script once against a fresh database. The `CREATE TABLE` statements will fail if those tables already exist.

### 3. Check the Connection String

The application uses this connection string:

```csharp
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"
```

If you use a different SQL Server instance, update the connection strings in the application’s forms.

Connection strings are currently repeated across multiple forms, so update every applicable occurrence.

### 4. Open and Build

1. Open **`LibraryManagemwntGUI.slnx`** in Visual Studio.
2. Allow NuGet packages to restore.
3. Select **Build → Rebuild Solution**.
4. Run the application.

Alternatively, open **`LibraryManagemwntGUI.csproj`** inside the project folder.

The `bin` and `obj` folders are generated automatically during the build and are not required in the repository.

### 5. Sign In

Use the demonstration account:

| Field | Value |
| --- | --- |
| Username | `1234` |
| Password | `1234` |

These credentials are for local demonstration only.

## What I Learned

This project helped me practice:

- Designing desktop interfaces with Windows Forms.
- Connecting buttons, menus, and search fields to event handlers.
- Connecting a C# application to SQL Server.
- Performing create, read, update, and delete operations.
- Displaying query results using DataGridView.
- Tracking borrowing activity through issue and return records.
- Providing confirmation dialogs and validation messages.
- Organizing functionality across multiple forms.

## Current Limitations

This application was developed as a learning project and is not intended for production use in its current state.

- Passwords are stored as plain text.
- Several SQL operations construct queries using user input and need to be converted to parameterized queries.
- Database connection settings are repeated across forms.
- Input validation and exception handling need improvement.
- Dates are stored as text rather than SQL date types.
- Automated tests are not included.

Use sample records and demonstration credentials when exploring the application.

## Future Improvements

- Use parameterized queries throughout the application.
- Introduce password hashing.
- Centralize database configuration and connection handling.
- Separate database access from interface logic.
- Improve validation and error reporting.
- Strengthen database constraints and date handling.
- Add more comprehensive inventory and borrowing checks.
- Introduce automated tests.

These are planned improvements, not features of the current implementation.

## Author

**Kazim Nawaz Abbasi**

Software Engineering student at **Atatürk University, Türkiye**.
