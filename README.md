---

# C# Fundamentals and OOP Evidence Project

This repository contains a collection of C# programs developed to demonstrate core programming concepts and Object-Oriented Programming (OOP) principles. The project is divided into two primary sections: language fundamentals and a vehicle management model.

## 👤 Author Information

* **Name:** Shamsul Arefin 
---

## 📂 Project Structure

### 1. Evidence_01: C# Language Fundamentals

The `Program.cs` file serves as a comprehensive demonstration of basic to intermediate C# features. Key concepts implemented include:

* **Error Handling:** Implementation of `try-catch-finally` blocks and custom exception throwing.
* **Arithmetic & Logic:** Demonstrations of arithmetic operators, prefix/postfix operations, and short-circuit logic (`&&`, `||`).
* **Data Types:** Usage of primitive data types (string, int, decimal, float, long, double, bool), `DateTime`, and anonymous types.
* **Control Flow:** Examples of decision-making (`if-else`, `switch`) and various loops (`while`, `do-while`, `for`, `foreach`).
* **Method Parameters:** Advanced method signatures using named arguments, optional parameters, and return values.
* **Context Management:** Use of `checked` and `unchecked` blocks to handle integral-type arithmetic overflow.

### 2. Evidence_02: Object-Oriented Design (Vehicle Model)

This module demonstrates the application of OOP principles such as **Inheritance**, **Interfaces**, and **Encapuslation**.

#### Key Components:

* **`Vehicel` (Base Class):** Defines common properties for all vehicles, including `ModelName`, `YearMake`, `CC`, and `VehicelType`.
* **`TwoWheeler` (Derived Class):** Inherits from `Vehicel` and implements specific properties like `StartingMethod`, `Mileage`, and braking systems.
* **Interfaces:**
* `IExteriorDesign`: Defines methods for adding and retrieving exterior design specifications.
* `IInteriorDesign`: Provides a contract for interior design management.


* **`VehicelType` (Enum):** Categorizes vehicles into `Personal`, `Family`, `Sports`, or `Racing`.

---

## 🛠️ Requirements & Setup

* **.NET SDK:** Compatible with .NET Framework or .NET Core (depending on your environment).
* **IDE:** Visual Studio 2022 or VS Code.

### How to Run

1. Clone the repository.
2. Open the `EXAM.slnx` solution file.


3. Set `Evidence_01` as the startup project to view the fundamentals console output.
4. Build the solution to ensure all dependencies and interfaces in `Evidence_02.Model` are correctly linked.

---

## 📝 Code Highlights

### Checked vs Unchecked Example

The project demonstrates how C# handles memory overflow:

```csharp
checked {
    int a = int.MaxValue;
    a++; // This will throw an OverflowException
}

```

### Interface Implementation

The `TwoWheeler` class utilizes a `List<string>` to manage design elements dynamically via the `params` keyword:

```csharp
public void AddExtetiorDesign(params string[] Design) {
    this.ex_Design.AddRange(Design);
}

```
