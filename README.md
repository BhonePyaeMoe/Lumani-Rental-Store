# Lumani Rental Store

**Lumani Rental Store** is a rental management software built using **pure C# (Windows Forms)**. It helps manage rental items, customers, transactions, and returns in an organized and efficient way.

The project uses a **MySQL** database to store all data related to inventory and operations. The database schema is provided in the `/Database` folder.

---

## 🛠 Features

- Customer registration and tracking
- Item listing and availability
- Rental and return transaction logging
- Simple and clean user interface
- MySQL database integration

---

## ✅ Prerequisites

- **.NET Framework (version 4.x)** or later
- **Visual Studio** (2019 or later recommended)
- **MySQL Server** already installed and running

---

## 📥 Installation

### 1. Clone the Repository

git clone https://github.com/yourusername/lumani-rental-store.git
cd lumani-rental-store

### 2. Import the Database
Open your MySQL interface (e.g., MySQL Workbench or CLI).

Run the SQL script in the Database/ folder:
SOURCE path/to/lumani_rental_store.sql;
This script will create a database named Lumani Rental with all required tables.



## ▶️ Run the Application

Open LumaniRentalStore.sln in Visual Studio.

Build the project (Build > Build Solution).

Press F5 or click Start to run the application.

You’ll be taken to the main dashboard of the Lumani Rental Store system.

## 🧪 Testing

You can test the following features once the application is running:

Add new customers

Add rental items

Create and return rental transactions

Check item availability

View and modify records

## ✏️ Notes
This project is written entirely in pure C# — no third-party front-end libraries or frameworks.

The MySQL script provided sets up everything needed to run the system smoothly.

Make sure MySQL service is running before launching the software.

## 📃 License
This project is licensed under the MIT License. Feel free to use and modify as needed.

## 🙋‍♂️ Author
Developed by [Bhone Pyae Moe]
Contact: [bhonepyae.it@gmail.com]

Make sure MySQL service is running before launching the software.

## 📃 License
This project is licensed under the MIT License. Feel free to use and modify as needed.
