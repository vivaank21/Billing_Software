# Billing Software

A comprehensive desktop application for managing invoices, inventory, customers, and generating billing reports. Built with C# Windows Forms and SQL Server.

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![Version](https://img.shields.io/badge/version-1.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Language](https://img.shields.io/badge/language-C%23-.NET-blueviolet)

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [System Requirements](#system-requirements)
- [Project Architecture](#project-architecture)
- [Installation & Setup](#installation--setup)
- [Database Configuration](#database-configuration)
- [Project Structure](#project-structure)
- [Module Descriptions](#module-descriptions)
- [Usage Guide](#usage-guide)
- [Database Schema](#database-schema)
- [Contributing](#contributing)
- [License](#license)

---

## 🎯 Overview

**Billing Software** is a professional-grade Windows desktop application designed to streamline business operations by providing:

- **Invoice Management**: Create, update, and track invoices with automatic numbering
- **Inventory Management**: Manage products, categories, and stock levels
- **Customer Database**: Maintain comprehensive customer information and records
- **Billing & Reporting**: Generate detailed reports and export data to Excel
- **Secure Authentication**: User login system with integrated security

The application follows a **3-tier architecture** with separation of concerns using the **Data Access Layer (DAL)** and **Model (GETSET)** patterns for clean, maintainable code.

---

## ✨ Features

### Core Features
- ✅ **User Authentication**: Secure login system for application access
- ✅ **Invoice Management**: 
  - Create new invoices with automatic invoice number generation (INVO-XXXX format)
  - Calculate totals with tax and discount support
  - Update existing invoices
  - View invoice history and details

- ✅ **Inventory Management**:
  - Add, edit, and delete products
  - Organize products by categories
  - Track product stock levels
  - Manage product pricing and descriptions

- ✅ **Customer Management**:
  - Maintain customer database with contact information
  - Store customer addresses and mobile numbers
  - Link customers to invoices

- ✅ **Records Management**:
  - View all records (products, customers, invoices)
  - Search and filter functionality
  - Data validation and error handling

- ✅ **Reporting**:
  - Generate comprehensive database reports
  - Export data to Excel
  - Export reports as text files
  - Real-time statistics and summaries

- ✅ **Utilities**:
  - Notes application for quick notes
  - Real-time clock and date display
  - File save/open dialogs for notes

---

## 💻 System Requirements

### Minimum Requirements
| Requirement | Version/Specification |
|---|---|
| **Operating System** | Windows 7 SP1 or higher |
| **.NET Framework** | .NET Framework 4.7.2 or higher |
| **SQL Server** | SQL Server 2012 or higher (Express Edition supported) |
| **RAM** | 2 GB |
| **Disk Space** | 100 MB |

### Recommended Requirements
| Requirement | Version/Specification |
|---|---|
| **Operating System** | Windows 10/11 |
| **.NET Framework** | .NET Framework 4.8 or higher |
| **SQL Server** | SQL Server 2016 or higher |
| **RAM** | 4 GB or more |
| **Disk Space** | 500 MB |

### Required Software
- Visual Studio 2015 or higher (for development)
- SQL Server Management Studio (for database management)
- Microsoft Office (for Excel export feature)

---

## 🏗️ Project Architecture

The application follows a **3-Tier Architecture**:

```
┌─────────────────────────────────────┐
│   Presentation Layer (GUI)          │
│  - Windows Forms (WinForms)         │
│  - User Interface Components        │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│   Business Logic Layer (Models)     │
│  - GETSET Classes (Data Models)     │
│  - Data Validation                  │
│  - Business Rules                   │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│   Data Access Layer (DAL)           │
│  - SQL Operations (CRUD)            │
│  - Database Queries                 │
│  - Connection Management            │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│   Data Layer                        │
│  - SQL Server Database              │
│  - Data Storage & Retrieval         │
└─────────────────────────────────────┘
```

---

## 🚀 Installation & Setup

### Step 1: Clone/Download the Project

```bash
# Clone the repository
git clone [repository-url]
cd Billing_Software
```

### Step 2: Install Prerequisites

1. **Install .NET Framework 4.7.2**
   - Download from: https://dotnet.microsoft.com/download/dotnet-framework

2. **Install SQL Server**
   - SQL Server Express (Free): https://www.microsoft.com/en-us/sql-server/sql-server-express

3. **Install Visual Studio** (for development)
   - Visual Studio Community (Free): https://visualstudio.microsoft.com/

### Step 3: Open in Visual Studio

```bash
# Open the solution file
Billing_Software.sln
```

### Step 4: Build the Project

```bash
# Build the solution
Build → Build Solution (Ctrl + Shift + B)
```

### Step 5: Run the Application

```bash
# Press F5 or Click Debug → Start Debugging
F5
```

---

## 🗄️ Database Configuration

### Step 1: Create the Database

1. Open **SQL Server Management Studio**
2. Create a new database named `prj_DB`

```sql
CREATE DATABASE prj_DB;
GO
```

### Step 2: Create Tables

Run the following SQL scripts to create required tables:

```sql
-- Create Categories Table
CREATE TABLE tbl__category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL,
    CategoryDescription NVARCHAR(255)
);

-- Create Products Table
CREATE TABLE tbl__products (
    productID INT PRIMARY KEY IDENTITY(1,1),
    productname NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    CategoryID INT,
    Size NVARCHAR(50),
    Rate DECIMAL(10, 2),
    Stock DECIMAL(10, 2),
    FOREIGN KEY (CategoryID) REFERENCES tbl__category(CategoryID)
);

-- Create Customers Table
CREATE TABLE tbl__customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    MobileNo NVARCHAR(15),
    Address NVARCHAR(255)
);

-- Create Invoices Table
CREATE TABLE tbl__invoice2 (
    invoiceID INT PRIMARY KEY IDENTITY(1,1),
    invoiceno NVARCHAR(20) UNIQUE NOT NULL,
    invoicedate DATETIME,
    CustomerID INT,
    totalamount DECIMAL(10, 2),
    tax DECIMAL(10, 2),
    discount DECIMAL(10, 2),
    grandtotal DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES tbl__customers(CustomerID)
);

-- Create Invoice Details Table
CREATE TABLE tbl__invoicedetails (
    invoiceDetailID INT PRIMARY KEY IDENTITY(1,1),
    invoiceID INT,
    productID INT,
    quantity DECIMAL(10, 2),
    unitprice DECIMAL(10, 2),
    total DECIMAL(10, 2),
    FOREIGN KEY (invoiceID) REFERENCES tbl__invoice2(invoiceID),
    FOREIGN KEY (productID) REFERENCES tbl__products(productID)
);

-- Create Items Table
CREATE TABLE tbl__items (
    itemID INT PRIMARY KEY IDENTITY(1,1),
    itemName NVARCHAR(100),
    itemPrice DECIMAL(10, 2)
);

-- Create Users Table (for authentication)
CREATE TABLE tbl__users (
    userID INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50) UNIQUE NOT NULL,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(100),
    createdDate DATETIME DEFAULT GETDATE()
);
```

### Step 3: Update Connection String

Edit `Connection/ConnectiontoDB.cs` and update the connection string:

```csharp
public static String Connection_str = "Data Source=YOUR_SERVER_NAME;Initial Catalog=prj_DB;Integrated Security=True";
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g., `LAPTOP-XXXXX`, `.\SQLEXPRESS`, `localhost`)

---

## 📁 Project Structure

```
Billing_Software/
├── Billing_Software.sln                 # Solution file
├── Billing_Software/
│   ├── Program.cs                       # Application entry point
│   ├── App.config                       # Configuration file
│   │
│   ├── Connection/
│   │   └── ConnectiontoDB.cs            # Database connection class
│   │
│   ├── GUI/                             # User Interface (Windows Forms)
│   │   ├── Page__Login.cs/Designer.cs   # Login form
│   │   ├── page__MAIN.cs/Designer.cs    # Main dashboard
│   │   ├── page__INVOICE.cs/Designer.cs # Invoice management
│   │   ├── page__INVENTORY.cs/Designer.cs # Inventory management
│   │   ├── page__RECORDS.cs/Designer.cs # Records view
│   │   └── *.resx                       # UI resources
│   │
│   ├── DAL/                             # Data Access Layer
│   │   ├── Invoice_DAL.cs               # Invoice database operations
│   │   ├── InvoiceDetail__DAL.cs        # Invoice detail operations
│   │   ├── Customer_DAL.cs              # Customer operations
│   │   ├── Product_DAL.cs               # Product operations
│   │   ├── Item_DAL.cs                  # Item operations
│   │   └── Records_DAL.cs               # Records operations
│   │
│   ├── GETTERnSETTER/                   # Data Models
│   │   ├── Invoice__getset.cs           # Invoice model
│   │   ├── InvoiceDetail__getset.cs     # Invoice detail model
│   │   ├── Customer__getset.cs          # Customer model
│   │   ├── Product__getset.cs           # Product model
│   │   └── Item__getset.cs              # Item model
│   │
│   ├── Properties/
│   │   ├── AssemblyInfo.cs              # Assembly metadata
│   │   ├── Resources.resx               # Resource file
│   │   └── Settings.settings            # Application settings
│   │
│   ├── Resources/                       # Images and icons
│   │   ├── closeIcon.png
│   │   └── minimizeIcon.png
│   │
│   └── bin/Debug/                       # Compiled executable
│       └── Billing_Software.exe
│
└── README.md                            # This file
```

---

## 📦 Module Descriptions

### 1. **Authentication Module** (`Page__Login.cs`)
- User login interface
- Credential validation
- Access control to main application
- Session management

### 2. **Dashboard Module** (`page__MAIN.cs`)
- Application home page
- Real-time clock and date display
- Notes application (create, save, open)
- Navigation to all modules
- Report generation
- Database backup functionality

### 3. **Invoice Module** (`page__INVOICE.cs`)
- Create new invoices
- Add invoice line items
- Calculate subtotals, tax, and discounts
- Update invoice details
- View invoice history
- Invoice number auto-generation (INVO-XXXX format)

### 4. **Inventory Module** (`page__INVENTORY.cs`)
- Product management (Add, Edit, Delete)
- Category management
- Stock level tracking
- Product pricing and descriptions
- Real-time inventory updates

### 5. **Records Module** (`page__RECORDS.cs`)
- View all customers
- View all products
- View all invoices
- Search and filter records
- Data validation

### 6. **Data Access Layer (DAL)**
Each DAL class handles database CRUD operations:
- `Invoice_DAL.cs` - Insert, update, retrieve invoices
- `Customer_DAL.cs` - Customer database operations
- `Product_DAL.cs` - Product database operations
- `InvoiceDetail__DAL.cs` - Invoice line items
- `Item_DAL.cs` - Item management
- `Records_DAL.cs` - General record operations

### 7. **Data Models (GETTERnSETTER)**
Classes that represent business entities:
```csharp
- Invoice__getset    // Invoice properties
- Customer__getset   // Customer properties
- Product__getset    // Product properties
- InvoiceDetail__getset // Line item properties
- Item__getset       // Item properties
```

---

## 🎮 Usage Guide

### Login
1. Launch the application
2. Enter valid username and password
3. Click "Login"

### Create Invoice
1. Navigate to **Invoice** module
2. Click "New Invoice"
3. Select customer or create new customer
4. Add products/items to invoice
5. Set quantity and price
6. Apply tax and discount if needed
7. Click "Save" to generate invoice

### Manage Inventory
1. Go to **Inventory** module
2. Click "Add Product"
3. Enter product details (name, category, price, stock)
4. Save product
5. Edit or delete products as needed

### View Records
1. Navigate to **Records** module
2. View all customers, products, and invoices
3. Use search to filter data
4. Click on records for detailed view

### Generate Reports
1. From **Main Dashboard**
2. Click "Reports/Backup"
3. Report will be generated to Desktop as `DatabaseBackup.txt`
4. Export data to Excel using built-in functions

### Notes Application
1. In **Main Dashboard**
2. Click "Save Notes" to save notes to file
3. Click "Open Notes" to load saved notes
4. Click "Clear Notes" to empty text area

---

## 🗄️ Database Schema

### Key Tables

#### tbl__customers
```
CustomerID (PK)  | INT
CustomerName     | NVARCHAR(100)
MobileNo         | NVARCHAR(15)
Address          | NVARCHAR(255)
```

#### tbl__products
```
productID (PK)   | INT
productname      | NVARCHAR(100)
Description      | NVARCHAR(255)
CategoryID (FK)  | INT
Size             | NVARCHAR(50)
Rate             | DECIMAL(10,2)
Stock            | DECIMAL(10,2)
```

#### tbl__invoice2
```
invoiceID (PK)   | INT
invoiceno (UQ)   | NVARCHAR(20)
invoicedate      | DATETIME
CustomerID (FK)  | INT
totalamount      | DECIMAL(10,2)
tax              | DECIMAL(10,2)
discount         | DECIMAL(10,2)
grandtotal       | DECIMAL(10,2)
```

#### tbl__category
```
CategoryID (PK)  | INT
CategoryName     | NVARCHAR(100)
CategoryDesc     | NVARCHAR(255)
```

#### tbl__invoicedetails
```
invoiceDetailID (PK) | INT
invoiceID (FK)       | INT
productID (FK)       | INT
quantity             | DECIMAL(10,2)
unitprice            | DECIMAL(10,2)
total                | DECIMAL(10,2)
```

---

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| **C# .NET 4.7.2** | Backend programming language |
| **Windows Forms** | GUI framework |
| **SQL Server** | Database management |
| **ADO.NET** | Data access |
| **Microsoft Office Interop** | Excel export functionality |

---

## 📝 Key Features Implementation

### Auto-Invoice Numbering
Invoices are automatically numbered in the format `INVO-XXXX` (e.g., INVO-0001, INVO-0002)
```csharp
// Format: INVO-0001, INVO-0002, etc.
public string GenerateNextInvoiceNumber()
{
    // Retrieves last invoice number from database
    // Increments and returns new number
}
```

### Tax & Discount Calculation
```
Grand Total = Total Amount + Tax - Discount
```

### Real-time Clock
Updates in real-time showing current time, date, and day of week

### Database Backup
Exports all data (categories, products, customers, invoices) to text file

---

## ⚙️ Configuration

### Connection String
Located in: `Connection/ConnectiontoDB.cs`

```csharp
public static String Connection_str = "Data Source=LAPTOP-6LPJ4I20;Initial Catalog=prj_DB;Integrated Security=True";
```

Update server name and database name as needed.

### App Settings
Located in: `App.config`

```xml
<configuration>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
</configuration>
```

---

## 🐛 Troubleshooting

### Issue: "Cannot connect to database"
**Solution**: 
1. Check SQL Server is running
2. Verify connection string in `ConnectiontoDB.cs`
3. Ensure database `prj_DB` exists
4. Check SQL Server authentication mode (Windows/Mixed)

### Issue: "Table not found" error
**Solution**:
1. Run the SQL scripts to create all required tables
2. Verify database tables exist using SQL Server Management Studio

### Issue: "Excel export not working"
**Solution**:
1. Ensure Microsoft Office is installed
2. Check interop assemblies are properly referenced in .csproj

### Issue: Login fails
**Solution**:
1. Verify user exists in `tbl__users` table
2. Check password is correct
3. Ensure SQL Server connection is working

---

## 📊 Performance Considerations

- Use indexed columns for frequently queried fields (CustomerID, productID)
- Implement query optimization for large datasets
- Cache frequently accessed data where appropriate
- Archive old invoices periodically for better performance

---

## 🔒 Security Best Practices

1. **Password Storage**: Implement password hashing (currently plaintext - needs improvement)
2. **SQL Injection**: Use parameterized queries (already implemented)
3. **Access Control**: Implement role-based access control
4. **Audit Trail**: Log all user activities
5. **Data Encryption**: Encrypt sensitive data at rest

### Future Security Improvements
- [ ] Implement password hashing with bcrypt/SHA256
- [ ] Add role-based access control (Admin, Manager, User)
- [ ] Implement audit logging
- [ ] Add data encryption for sensitive fields
- [ ] Implement API authentication tokens

---

## 🚀 Future Enhancements

- [ ] **Cloud Integration**: Sync with cloud databases
- [ ] **Mobile App**: Companion mobile application
- [ ] **Advanced Reports**: Graphical charts and analytics
- [ ] **Multi-user Support**: Concurrent user handling
- [ ] **Backup & Recovery**: Automated backup system
- [ ] **Customer Portal**: Online invoice tracking
- [ ] **Payment Gateway Integration**: Online payments
- [ ] **Email Integration**: Send invoices via email
- [ ] **Barcode Support**: Product barcode scanning
- [ ] **Multi-language**: Localization support

---

## 📖 Documentation

For detailed API documentation and code examples, refer to:
- Code comments in source files
- Inline XML documentation
- SQL table schemas

---

## 👥 Contributing

Contributions are welcome! Please follow these guidelines:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Development Setup
```bash
git clone [repository-url]
cd Billing_Software
# Follow Installation & Setup steps above
# Make changes
# Test thoroughly
# Submit PR
```

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

```
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction...
```

---

## 📞 Support & Contact

For issues, questions, or suggestions:
- **Email**: vishukava16@gmail.com
- **GitHub Issues**: [Project Issues Page]
- **Documentation**: See inline code comments

---

## 🙏 Acknowledgments

- Built with C# .NET Framework
- UI Framework: Windows Forms
- Database: SQL Server
- Special thanks to contributors and users

---

## 📋 Version History

### v1.0 (Current Release)
- Initial release
- Core features: Invoice, Inventory, Customer, Records management
- Database backup and reporting
- Notes application

### v1.1 (Upcoming)
- Bug fixes and optimizations
- Enhanced reporting features
- Performance improvements

---

**Last Updated**: June 2025  
**Status**: Active Development  
**Maintainers**: Vishu Kava

---

## Quick Links

- [Installation Guide](#installation--setup)
- [Database Setup](#database-configuration)
- [Project Structure](#-project-structure)
- [Usage Guide](#-usage-guide)
- [Troubleshooting](#-troubleshooting)

---

*This README provides comprehensive documentation for the Billing Software project. For technical details, refer to inline code comments and the project's source code.*
