# Visa Application Manager
### Introduction
This ASP.NET MVC application allows users to manage visa applications. It supports creating, viewing, updating, and deleting visa applications.

### Features
Create Visa Applications: Users can submit new visa applications including details like user name, passport copy, visa type, country of application, and application status.
View Visa Applications: Users and admins can view all submitted applications.
Edit Visa Applications: Admins can update the status and details of any application.
Delete Visa Applications: Admins can remove applications from the system.
Technology Stack
ASP.NET MVC
Entity Framework Core
SQL Server
Bootstrap for responsive design
Project Structure
Models
VisaApplication: Represents the visa application data.
Views
VisaApplications: Contains views for CRUD operations (Create, Read, Update, Delete).
Controllers
VisaApplicationsController: Handles the logic for CRUD operations.
Data
ApplicationDbContext: EF Core context used for database operations.
Setup Instructions
Prerequisites:

Visual Studio 2019 or later
.NET Core 3.1 SDK or later
SQL Server 2019 Express or later
Database Setup:

Ensure SQL Server is installed and running.
Update the connection string in appsettings.json with your SQL Server instance name:
json
Copy code
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=VisaApplicationDb;Trusted_Connection=True;"
}
Running Migrations:

Open the Package Manager Console in Visual Studio.
Run the following command to apply migrations to the database:
mathematica
Copy code
Update-Database
Running the Application:

Open the solution in Visual Studio.
Build the solution by hitting Ctrl + Shift + B.
Run the application by hitting F5 or clicking on the green play button.
Accessing the Application:

The application will start in your default web browser at https://localhost:{PORT}.
Navigate to /VisaApplications to start interacting with the application.
How to Use
Create a Visa Application: Click on 'Create New' on the Visa Applications page, fill in the details, and submit.
View Applications: All applications can be viewed on the Index page of the Visa Applications section.
Edit/Delete an Application: Use the 'Edit' or 'Delete' links next to each application on the list.
Additional Information
The application uses Bootstrap 4 for styling. Customize the styles in the wwwroot/css directory.
If encountering any issues during setup or operations, ensure all configurations in appsettings.json are correct and that SQL Server is accessible.
