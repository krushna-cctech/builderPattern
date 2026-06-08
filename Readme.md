# Builder Design Pattern in C#

This project demonstrates the **Builder Design Pattern** using a simple **Computer Configuration System** example.

The Builder Pattern is a **Creational Design Pattern** that allows complex objects to be constructed step by step. It separates the construction process from the final object representation.

---

## 📂 Project Structure

```text
BuilderPatternDemo/
│
├── Models/
│   └── Computer.cs
│
├── Builders/
│   ├── IComputerBuilder.cs
│   └── ComputerBuilder.cs
│
├── Director/
│   └── ComputerDirector.cs
│
└── Program.cs
```

---

## 🎯 Problem

Suppose we need to create different types of computers:

- Gaming PC
- Office PC
- Workstation PC

Using constructors with many parameters can become difficult to manage:

```csharp
Computer pc = new Computer(
    "Intel i9",
    "32GB",
    "1TB SSD",
    "RTX 4080"
);
```

As the number of attributes grows, constructors become harder to read and maintain.

The Builder Pattern solves this by constructing the object step by step.

---

## 🏗 Components of Builder Pattern

### 1. Product

The complex object being built.

**Example:**

```csharp
Computer
```

Contains:

- CPU
- RAM
- Storage
- GPU

---

### 2. Builder Interface

Defines the steps required to build the product.

**Example:**

```csharp
IComputerBuilder
```

Methods:

```csharp
SetCPU()
SetRAM()
SetStorage()
SetGPU()
GetComputer()
```

---

### 3. Concrete Builder

Implements the builder interface and creates the actual object.

**Example:**

```csharp
ComputerBuilder
```

Responsibilities:

- Creates the Computer object
- Sets individual properties
- Returns the completed object

---

### 4. Director

Controls the construction process.

**Example:**

```csharp
ComputerDirector
```

Creates predefined configurations such as:

- Gaming PC
- Office PC

---

### 5. Client

Uses the Director and Builder.

**Example:**

```csharp
Program.cs
```

---

## 🔄 Workflow

```text
Client
   |
   v
Director
   |
   v
Builder Interface
   |
   v
Concrete Builder
   |
   v
Product (Computer)
```

---

## 💻 Example Output

```text
Gaming PC:
CPU: Intel i9
RAM: 32GB
Storage: 1TB SSD
GPU: RTX 4080
```

---

## ✅ Advantages

### 1. Better Readability

Object creation becomes more understandable.

```csharp
builder.SetCPU("Intel i9");
builder.SetRAM("32GB");
```

instead of:

```csharp
new Computer("Intel i9","32GB","1TB SSD","RTX 4080");
```

---

### 2. Separation of Concerns

Construction logic is separated from the business logic.

---

### 3. Reusability

The same builder can be used to create different configurations.

---

### 4. Maintainability

Adding new fields requires minimal code changes.

---

### 5. Flexible Object Creation

Different representations can be built using the same construction process.

---

## 🚀 Real-World Use Cases

The Builder Pattern is commonly used in:

### Software Development

- Configuration Objects
- Database Connection Builders
- API Request Builders

### Enterprise Applications

- Report Generation Systems
- Invoice Generation
- Document Creation

### UI Development

- Form Builders
- Dashboard Builders
- UI Component Construction

### .NET Examples

Commonly seen in:

```csharp
StringBuilder
HostBuilder
WebApplicationBuilder
ConfigurationBuilder
```

---

## 📚 Design Pattern Category

| Pattern | Category |
|----------|----------|
| Builder | Creational Design Pattern |

Creational patterns focus on how objects are created.

Other Creational Patterns:

- Singleton
- Factory Method
- Abstract Factory
- Prototype
- Builder

---

## 🎓 Key Takeaway

The **Builder Design Pattern** is useful when:

- Objects have many properties.
- Construction requires multiple steps.
- Different object configurations are needed.
- Constructors become too large or complex.

It improves **readability**, **maintainability**, and **flexibility** by separating the construction process from the final object.