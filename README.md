# ⚡ .NET Distributed Microservices Architecture

A distributed microservices application built with **.NET 8 / C#**, demonstrating clean architecture, asynchronous messaging, and containerized deployment.

---

## 🏛️ Services & Components

- 📡 **Platform Service:** Manages platform catalog and publishes events to downstream consumers.
- ⌨️ **Commands Service (`CommandsService`):** Consumes platform data, provides command APIs, and maintains synchronized local state.
- 📨 **Event Bus & Messaging:** Asynchronous event communication powered by RabbitMQ.
- 🌐 **Synchronous Communication:** REST APIs and gRPC communication between internal services.
- ☸️ **Kubernetes Orchestration:** Production manifests for deployments, services, and ingress.

---

## 🛠️ Tech Stack

- **Platform:** .NET 8 (C#)
- **Frameworks:** ASP.NET Core Web API, AutoMapper, EF Core
- **Messaging:** RabbitMQ
- **Communication:** REST, gRPC
- **Containerization & Infra:** Docker, Kubernetes (K8s)

---

## 🚀 Getting Started

```bash
# Clone the repository
git clone https://github.com/SongUylong/dotnet-microservices.git
cd dotnet-microservices

# Run CommandsService
cd CommandsService
dotnet restore
dotnet run
```

---

## 👤 Author

**Song Uylong** ([@SongUylong](https://github.com/SongUylong))
