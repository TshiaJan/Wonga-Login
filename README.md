# Login Assessment

This project implements a simple login system with frontend in React and backend in C# ASP.NET Core, using PostgreSQL in Docker.

## How to Run

1. Install Docker Desktop.
2. Clone this repo: `git clone <your-repo-url>`
3. In root, run `docker-compose up` to start backend and DB.
4. In `/frontend`, run `npm install` then `npm start` (runs on localhost:3000).
5. Use Postman to test API endpoints at http://localhost:5000/api/auth/register, /login, /details.

## How It Works

- **Frontend**: React with routes for register, login, user details. Uses JWT token stored in localStorage for auth.
- **Backend**: ASP.NET Core API with EF Core for DB. JWT for authentication. Passwords hashed with SHA256.
- **Database**: PostgreSQL in Docker, with auto-migrations.
- **Tests**: Unit tests in `/backend/Tests`. For integration tests (bonus), extend with WebApplicationFactory.
- **Bonus**: Build script could be added as a bash file; microservices not implemented for simplicity.

Change secrets in appsettings.json and docker-compose.yml before production use.

Access the repo at: <your-repo-url>
