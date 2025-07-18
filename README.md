# PorcXarxaAPI

**RESTful API for managing pig farms in Catalonia**  
_Built with ASP.NET 9 and Clean Architecture_

---

## 🚜 About the Project

**PorcXarxaAPI** is a RESTful web API currently in development, designed specifically for livestock companies operating in **Catalonia (Catalunya)**. This solution is tailored to the **porcine farming sector**, offering digital infrastructure to manage farms and facilitate integration with public agricultural platforms.

Each livestock company runs its **own deployed instance** of the API, fully configured and isolated per client.

---

## 🐷 Target Audience

This API is intended for:

- Pig farming companies based **exclusively in Catalonia**
- Agricultural cooperatives and associations focused on **porcine livestock**
- Businesses aiming to integrate with **GTR (Gestió Telemàtica Ramadera)** and other services from the **Departament d'Acció Climàtica, Alimentació i Agenda Rural** (Department of Agriculture)
- Livestock management platforms requiring a secure backend and farm data centralization

---


## 🧪 Version Information

> **Current Version**: `1.0`

- Version 1.0 uses a single-tenant model, where each deployed instance serves a single company with its own dedicated database.
- A **multi-tenant upgrade** (one database per company, dynamic provisioning) is planned for **Version 2.0**.
- In v2, a single deployment could manage multiple companies securely and independently.

---

## 🛠️ API Features (in progress)

- User registration and login
- CRUD operations for pig farms
- Role-based access control
- Email notifications
- Centralized logging and error handling

---

## 📍 Future Integration Plans

> ⚠️ These modules are **planned** but not yet implemented.

- Integration with Catalan government livestock systems:
  - **GTR (Gestió Telemàtica Ramadera)**
  - **SIRENTRA**
  - Other traceability and veterinary compliance tools
- Animal tracking and movement logs
- Treatment and medication records
- Certification for transport and health

---

## 🪪 License

**This project is restricted to view-only access.**

You may **not copy, use, deploy, or modify** any part of this codebase without **explicit written permission** from the owner.

To request usage rights or obtain a license, contact the project author.

---

## ✉️ Contact

For collaboration or commercial inquiries, please contact:

Felix Montragull Kruse
via GitHub