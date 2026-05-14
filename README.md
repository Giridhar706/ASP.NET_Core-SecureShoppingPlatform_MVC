# Secure Shopping Platform

## Overview

Secure Shopping Platform is an ASP.NET Core MVC web application developed to demonstrate secure coding practices in modern web applications.

The project implements authentication, role-based authorization, input validation, XSS prevention, SQL Injection prevention, password hashing, HTTPS security, and secure session handling.

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- In-Memory Database
- Cookie Authentication
- BCrypt Password Hashing
- HTML/CSS
- Razor Views

---

# Features Implemented

## Authentication & Authorization

- User Registration
- User Login
- Secure Logout
- Cookie-Based Authentication
- Role-Based Authorization
- Admin Dashboard Access Restriction

---

## Security Features

### Input Validation
Implemented using Data Annotations.

### SQL Injection Prevention
Entity Framework Core ORM is used instead of raw SQL queries.

### XSS Prevention
User-generated content is encoded using Html.Encode().

### Password Security
Passwords are hashed using BCrypt.

### HTTPS Security
HTTPS enabled for secure communication.

### Anti-Forgery Token
Implemented using ValidateAntiForgeryToken.

---

# Project Structure

```bash
SecureShoppingPlatform
│
├── Controllers
├── Models
├── Views
├── Data
├── Program.cs
└── SecureShoppingPlatform.csproj
```

---

# Test Credentials

## Admin Account

Email:
admin@gmail.com

Password:
Admin@123

---

## Customer Account

Email:
user@gmail.com

Password:
User@123

---

# Testing Security Features

## XSS Prevention Test

Enter:

```html
<script>alert('hack')</script>
```

Expected:
Script should not execute.

---

## SQL Injection Prevention Test

Enter:

```sql
' OR 1=1 --
```

Expected:
Application behaves normally without executing SQL commands.

---

# How To Run

1. Open Visual Studio 2026
2. Open `SecureShoppingPlatform.csproj`
3. Build Solution
4. Press `Ctrl + F5`

---

# Important URLs

| Feature | URL |
|---|---|
| Home | `/Home/Index` |
| Register | `/Account/Register` |
| Login | `/Account/Login` |
| Product List | `/Product` |
| Add Product | `/Product/Create` |
| Admin Dashboard | `/Admin/Dashboard` |
| Logout | `/Account/Logout` |

---

# Learning Outcomes

- ASP.NET Core MVC Architecture
- Secure Authentication
- Role-Based Authorization
- Secure Password Storage
- Secure Form Handling
- XSS Prevention
- SQL Injection Prevention
- HTTPS Security
- Entity Framework Core

---

# Author

Giridhar Gopal
