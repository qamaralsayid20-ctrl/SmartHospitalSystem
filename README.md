# 🏥 Smart Hospital System (Web API)

A smart, robust, and scalable Hospital Management Web API built using modern backend technologies to efficiently manage patient records and accurately assess medical cases.

## 🚀 About the Project
This project is a fully functional **Web API** designed for digital healthcare systems. It streamlines medical record organization, doctor and patient management, and implements an automated triage algorithm to evaluate patient health risk levels based on dynamic vital data (such as age and disease type).

## 🛠️ Tech Stack
* **Backend:** .NET 8 / C# ASP.NET Core Web API
* **Database:** Entity Framework Core (SQLite / SQL Server)
* **API Documentation:** Swagger UI (for seamless endpoint testing and interaction)

## 📌 Key Features
* **Patient Management (CRUD):** Seamlessly add, view, update, and delete patient records.
* **Automated Risk Assessment:** A smart programmatic algorithm that automatically classifies patient status into (**Low Risk** / **Medium Risk** / **High Risk**) to assist in immediate clinical prioritizing (Triage).
* **Robust Database Integration:** Utilizes Entity Framework Migrations to generate and update database schemas securely and rapidly.

## 📂 Project Structure & Architecture
* `Controllers/`: Contains the core API endpoints (e.g., `PatientsController`) to handle incoming HTTP requests.
* `Models/`: Data models representing core entities (e.g., Patient, Doctor, Diagnosis).
* `Data/`: Database context and connectivity configuration (`HospitalContext`).
