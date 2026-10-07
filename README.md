# RetinaAI — Diabetic Retinopathy Early Detection

Graduation project: a phone with a simple lens (IoT) captures a retina image, an AI model grades diabetic retinopathy (5 stages) and highlights affected areas with a Grad-CAM heatmap, and results are delivered to a mobile app and a hospital web dashboard.

## Project structure

```
Graduation-Project/
├── backend/RetinaApi/   ASP.NET Core Web API (C#) — server, database, connects to AI
├── frontend/            Hospital dashboard (HTML / CSS / JavaScript)
└── docs/                Plan, API contract, diagrams
```

## Tech stack (web)

| Part      | Technology                                  |
|-----------|---------------------------------------------|
| Frontend  | HTML, CSS, JavaScript, Bootstrap, Chart.js  |
| Backend   | ASP.NET Core Web API (.NET 10, C#)          |
| Database  | SQL Server / SQLite + Entity Framework Core |
| Auth      | JWT                                         |
| AI model  | Python (FastAPI) — owned by the AI team     |

## How to run

**Backend**
```
cd backend/RetinaApi
dotnet run --launch-profile http
```
Swagger opens at http://localhost:5210/swagger

**Frontend**
Open `frontend/index.html` in VS Code → right click → **Open with Live Server**.
