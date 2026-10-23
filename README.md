# RetinaAI — Diabetic Retinopathy Early Detection

> Graduation project · **in progress**

A low-cost screening system for diabetic retinopathy: a phone with a simple clip-on lens captures a retina image, an AI model grades it on the 5-stage scale and highlights affected areas with a Grad-CAM heatmap, and the result reaches the patient's mobile app and the doctor's hospital dashboard.

This repository holds the **back end** (ASP.NET Core Web API) that connects the mobile app, the web dashboard and the AI model.

## How it works

```
 Phone + lens ──► Mobile app ──┐
                               ├──► RetinaAI API (ASP.NET Core) ──► AI model (Python / FastAPI)
 Hospital dashboard (web) ─────┘            │
                                            ▼
                                   SQL Server (EF Core)
```

## Tech stack

| Part | Technology |
|---|---|
| API | ASP.NET Core Web API (.NET 10, C#), controllers |
| Database | SQL Server Express, Entity Framework Core 10 (code-first migrations) |
| API docs | Swagger / OpenAPI |
| AI model | Python (FastAPI), built by the AI team |
| Mobile app | Flutter, built by the mobile team |
| Web dashboard | HTML, CSS, JavaScript, Bootstrap, Chart.js |

## Data model

| Table | Holds |
|---|---|
| `Doctors` | Name, email, specialty, password hash |
| `Patients` | Age, gender, diabetes type and duration, HbA1c, assigned doctor |
| `Scans` | Eye (left / right), image and heatmap paths, AI grade and confidence, review status, doctor's note |

## API (so far)

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/status` | Health check |
| GET | `/api/patients` | List patients |
| GET | `/api/patients/{id}` | One patient |
| POST | `/api/patients` | Add a patient |

## Roadmap

- [x] Web API project and health-check endpoint
- [x] Database design (doctors, patients, scans) with EF Core and SQL Server
- [ ] Patients: full CRUD (update and delete next)
- [ ] Retina image upload and scan records
- [ ] Connect to the AI model (mock first, then the real one)
- [ ] Login for doctors and patients with JWT and roles
- [ ] Connect the web dashboard and mobile app
- [ ] End-to-end testing and deployment

## Run locally

Requirements: [.NET 10 SDK](https://dotnet.microsoft.com/download) and SQL Server Express.

```bash
cd backend
dotnet ef database update
dotnet run --launch-profile http
```

Swagger: **http://localhost:5131/swagger**

The connection string is in `backend/appsettings.json` (`Server=.\SQLEXPRESS`, Windows authentication). Change it if your SQL Server instance has a different name.

## My role

**Amany Khaled** — team lead and back-end developer: system and database design, the Web API, and coordinating integration between the AI, mobile and web teams.
