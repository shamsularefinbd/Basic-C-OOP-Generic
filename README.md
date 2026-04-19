🚗 C# Fundamentals & OOP Evidence Project

A collection of C# programs demonstrating core language features and Object-Oriented Programming principles, structured into two evidence modules.

---

## 👤 Author

**Shamsul Arefin**

---

## 📂 Project Structure

```
EXAM.slnx
├── Evidence_01/          # C# Language Fundamentals
│   └── Program.cs
└── Evidence_02/          # OOP Vehicle Model
    └── Model/
        ├── Vehicel.cs
        ├── TwoWheeler.cs
        ├── IExteriorDesign.cs
        ├── IInteriorDesign.cs
        └── VehicelType.cs
```

---

## 📘 Evidence_01 — C# Language Fundamentals

`Program.cs` covers a broad range of C# language features:

| Topic | Details |
|---|---|
| **Error Handling** | `try-catch-finally` blocks, custom exception throwing |
| **Arithmetic & Logic** | Arithmetic operators, prefix/postfix increment, short-circuit `&&` / `\|\|` |
| **Data Types** | `string`, `int`, `decimal`, `float`, `long`, `double`, `bool`, `DateTime`, anonymous types |
| **Control Flow** | `if-else`, `switch`, `while`, `do-while`, `for`, `foreach` |
| **Method Parameters** | Named arguments, optional parameters, return values |
| **Overflow Handling** | `checked` / `unchecked` blocks for integral arithmetic overflow |

### Highlight — Checked vs Unchecked

```csharp
// Throws OverflowException at runtime
checked {
    int a = int.MaxValue;
    a++;
}

// Silently wraps around (no exception)
unchecked {
    int b = int.MaxValue;
    b++;
}
```

---

## 🚙 Evidence_02 — Object-Oriented Vehicle Model

Demonstrates core OOP principles: **Inheritance**, **Interfaces**, and **Encapsulation**.

### Class Diagram

```
          «enum»
        VehicelType
   Personal | Family | Sports | Racing
                  |
           Vehicel (Base)
      ModelName, YearMake, CC, VehicelType
                  |
            TwoWheeler
   StartingMethod, Mileage, BrakingSystem
      implements IExteriorDesign
      implements IInteriorDesign
```

### Key Components

#### `Vehicel` — Base Class
Defines shared properties common to all vehicle types:
- `ModelName` — Name/model identifier
- `YearMake` — Manufacturing year
- `CC` — Engine displacement
- `VehicelType` — Enum-based category

#### `TwoWheeler` — Derived Class
Inherits from `Vehicel` and extends it with:
- `StartingMethod` — e.g. kick-start / self-start
- `Mileage` — Fuel efficiency
- Braking system details

#### Interfaces

| Interface | Responsibility |
|---|---|
| `IExteriorDesign` | Contract for adding and retrieving exterior design specs |
| `IInteriorDesign` | Contract for managing interior design details |

#### `VehicelType` — Enum

```csharp
public enum VehicelType {
    Personal,
    Family,
    Sports,
    Racing
}
```

### Highlight — Interface via `params`

```csharp
public void AddExteriorDesign(params string[] design) {
    this.ex_Design.AddRange(design);
}
```

Using `params` allows callers to pass any number of design elements in a single method call, backed by a `List<string>` for dynamic management.

---

## 🛠️ Requirements & Setup

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET Framework or .NET Core)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Getting Started

```bash
# 1. Clone the repository
git clone https://github.com/<your-username>/<repo-name>.git

# 2. Open the solution
#    Open EXAM.slnx in Visual Studio 2022

# 3. Run Evidence_01
#    Set Evidence_01 as the startup project and press F5

# 4. Build Evidence_02
#    Build the full solution to resolve all interface dependencies
```

---

## 🧠 OOP Concepts Demonstrated

| Concept | Where Applied |
|---|---|
| **Inheritance** | `TwoWheeler` extends `Vehicel` |
| **Encapsulation** | Private fields exposed via public properties |
| **Interface Segregation** | Separate `IExteriorDesign` and `IInteriorDesign` contracts |
| **Enumerations** | `VehicelType` for type-safe categorization |
| **Collections** | `List<string>` for dynamic design element storage |
