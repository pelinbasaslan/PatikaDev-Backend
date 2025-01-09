
# Employee Management System - Abstraction Practice

This project is a simple demonstration of **Abstraction** in object-oriented programming using C#. It simulates a system for managing employees in a company. Each employee has common attributes such as **Name**, **Surname**, and **Department**, but different job roles (e.g., Software Developer, Project Manager, and Sales Representative).

### Key Concepts:

1. **Abstraction**:
   - The concept of **abstract classes** is used to define common properties and methods for all employee roles.
   - The `Task()` method is **abstract** and must be implemented differently by each employee subclass.
   
2. **Polymorphism**:
   - Each subclass (e.g., `ProjectManager`, `SoftwareDeveloper`, `SalesRepresentative`) provides its own implementation of the `Task()` method, demonstrating polymorphism in action.

### Project Structure:

1. **Employee Class**:
   - This is an abstract class that contains common properties (`Name`, `SurName`, `Departmant`) and a concrete method `DisplayInfo()` to display employee details.
   - The `Task()` method is abstract and needs to be implemented in subclasses.

2. **ProjectManager Class**:
   - Inherits from `Employee` and implements the `Task()` method to display a message indicating that the employee is working as a Project Manager.

3. **SoftwareDeveloper Class**:
   - Inherits from `Employee` and implements the `Task()` method to display a message indicating that the employee is working as a Software Developer.

4. **SalesRepresentative Class**:
   - Inherits from `Employee` and implements the `Task()` method to display a message indicating that the employee is working as a Sales Representative.

### Features:

- **Abstract Class**: Used for common properties and to define the contract for `Task()`.
- **Polymorphism**: Allows different employee subclasses to have different implementations of the `Task()` method.
- **Encapsulation**: Employee details are encapsulated within the `Employee` class and can be accessed or modified through public properties.

### Example:

Here is how the program works:

```csharp
// Creating instances of different employees
Employee employee1 = new ProjectManager("Hasan", "Çıldırmış", "Hukuk");
employee1.DisplayInfo();
employee1.Task();

Employee employee2 = new SoftwareDeveloper("Pelin", "Başaslan", "Finas");
employee2.DisplayInfo();
employee2.Task();

Employee employee3 = new SalesRepresentative("Ahmet", "Yılmaz", "Satış");
employee3.DisplayInfo();
employee3.Task();
```

### Output:

```
Selamlar. Ben Hasan Çıldırmış. Hukuk departmanında,
Proje yöneticisi olarak çalışıyorum.
Selamlar. Ben Pelin Başaslan. Finas departmanında,
Yazılım geliştirici olarak çalışıyorum.
Selamlar. Ben Ahmet Yılmaz. Satış departmanında,
Satış temsilcisi olarak çalışıyorum.
```

### How to Run the Program:

1. **Clone this repository**:
   ```bash
   git clone https://github.com/yourusername/employee-management-system.git
   ```
   
2. **Open in Visual Studio**:
   - Open the solution file in Visual Studio or Visual Studio Code.

3. **Build and Run**:
   - Press `Ctrl + F5` to run the program or use the **Run** button in your IDE.

### Technologies Used:

- **C#**
- **Object-Oriented Programming (OOP) Principles**:
  - Abstraction
  - Polymorphism
  - Encapsulation

### Conclusion:

This project demonstrates the concept of **Abstraction** in C#. The abstract `Employee` class defines the core structure for all employees, while the specific employee roles (such as `ProjectManager`, `SoftwareDeveloper`, and `SalesRepresentative`) provide their own specific implementations of the `Task()` method.

---
