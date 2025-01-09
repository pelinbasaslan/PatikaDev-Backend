# README

## Overview

This project demonstrates the concept of **Inheritance** in object-oriented programming (OOP) using C#. In this application, we will create a base class called `BaseKisi`, which will serve as the foundation for two derived classes: `Ogrenci` (Student) and `Ogretmen` (Teacher). 

The `BaseKisi` class contains properties for a person's first name (`Name`) and last name (`SurName`), along with a method to print these details to the console.

The derived classes, `Ogrenci` and `Ogretmen`, extend `BaseKisi` by adding additional properties and methods specific to students and teachers, respectively. The `Ogrenci` class will include a student number (`StudentNumber`), and the `Ogretmen` class will include salary information (`Wage`). Each of these classes also contains a method to print relevant details.

## Table of Contents
1. [Classes](#classes)
   - BaseKisi Class
   - Ogrenci Class
   - Ogretmen Class
2. [How It Works](#how-it-works)
3. [Sample Usage](#sample-usage)
4. [Running the Code](#running-the-code)
5. [Conclusion](#conclusion)

---

## Classes

### BaseKisi Class
The `BaseKisi` class serves as the base for both `Ogrenci` and `Ogretmen`. It contains:

- **Properties**:
  - `Name` (First Name)
  - `SurName` (Last Name)

- **Methods**:
  - `DisplayInfo()`: Prints the first name and last name to the console.

```csharp
public class BaseKisi
{
    public string Name { get; set; }
    public string SurName { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Kişinin Adı:{Name}, Soyadı:{SurName}.");
    }

}
```

### Ogrenci Class
The `Ogrenci` class inherits from `BaseKisi` and adds additional functionality:

- **Properties**:
  - `StudentNumber` (Student Number)

- **Methods**:
  - `DisplayInfoOgrenci()`: Prints the first name, last name and student number to the console.

```csharp
public class Ogrenci : BaseKisi
{
    public string StudentNumber { get; set; }

    public void DisplayInfoOgrenci()
    {
        DisplayInfo();
        Console.WriteLine($"Öğrenci numarası:{StudentNumber}");
    }
}
```

### Ogretmen Class
The `Ogretmen` class inherits from `BaseKisi` and adds its own functionality:

- **Properties**:
  - `Wage` (Salary Information)

- **Methods**:
  - `DisplayInfoOgretmen()`: Prints the first name, last name and wage to the console.

```csharp
public class Ogretmen : BaseKisi
{
    public decimal Wage { get; set; }

    public void DisplayInfoOgretmen()
    {
        DisplayInfo();
        Console.WriteLine($"Maaşı: {Wage}");
    }
}
```

---

## How It Works

### 1. **Inheritance**

- The `Ogrenci` (Student) and `Ogretmen` (Teacher) classes inherit from the `BaseKisi` class. This means that both classes automatically inherit the following from `BaseKisi`:
  - **Properties**: `Name` (Name) and `SurName` (Surname).
  - **Method**: The `DisplayInfo()` method that prints the name and surname.

### 2. **Creating Custom Methods**

- Instead of overriding the `DisplayInfo()` method from the `BaseKisi` class, both `Ogrenci` and `Ogretmen` classes define their own **custom methods** to display more specific information.
  - The `Ogrenci` class defines a method called `DisplayInfoOgrenci()`, which prints the student number, name, and surname.
  - The `Ogretmen` class defines a method called `DisplayInfoOgretmen()`, which prints the salary, name, and surname.

This allows each class to have its own specific implementation for displaying information.

### 3. **Creating Objects**

- Instances of the `Ogrenci` and `Ogretmen` classes can be created.
- After creating the objects, you can set the values of their properties, including:
  - `Name` 
  - `Surname` 
  - Additional properties like `StudentNumber` (Student Number) for `Ogrenci`, and `Wage` (Salary) for `Ogretmen`.
  
- After setting the properties, you can call the specific method for each class to display the personalized information:
  - **For `Ogrenci` (Student)**: Call the `DisplayInfoOgrenci()` method.
  - **For `Ogretmen` (Teacher)**: Call the `DisplayInfoOgretmen()` method.

### Example Flow:
1. Create a new `Ogrenci` object, set its properties, and call the `DisplayInfoOgrenci()` method to print student details.
2. Create a new `Ogretmen` object, set its properties, and call the `DisplayInfoOgretmen()` method to print teacher details.

---

This revised **How It Works** section clearly explains the flow of the code, including how inheritance and custom methods are used in the `Ogrenci` and `Ogretmen` classes.
---

## Sample Usage

Here's an example of how you can use these classes in your program:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Ogrenci class
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Name = "Pelin";
        ogrenci.SurName = "Başaslan";
        ogrenci.StudentNumber = "111111";

        // Create an instance of the Ogretmen class
        Ogretmen ogretmen = new Ogretmen();
        ogretmen.Name = "Sertan";
        ogretmen.SurName = "Bozkuş";
        ogretmen.Wage = 100;

        // Print the student's details
        ogrenci.DisplayInfoOgrenci();
        // Print the teacher's details
        ogretmen.DisplayInfoOgretmen();
    }
}
```

---

## Running the Code

1. **Step 1**: Open your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
2. **Step 2**: Create a new Console Application project.
3. **Step 3**: Replace the contents of `Program.cs` with the code provided in the "Sample Usage" section.
4. **Step 4**: Run the application.
5. **Step 5**: The output will display the student and teacher details.

### Expected Output:
```
Kişinin Adı:Pelin, Soyadı:Başaslan.
Öğrenci numarası:111111
Kişinin Adı:Sertan, Soyadı:Bozkuş.
Maaşı: 100
```

---

## Conclusion

This project provides a basic example of how inheritance works in C#. By using a base class (`BaseKisi`) and deriving classes (`Ogrenci`, `Ogretmen`), we can create a flexible and extensible application that makes use of OOP principles such as inheritance, method overriding, and encapsulation.
