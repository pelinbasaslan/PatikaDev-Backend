# Patika Library - Book Registration Application

## Project Overview
This project aims to create a book registration application for the **Patika Library**. With this application, we can store information about books, such as the book title, author’s first and last name, page count, publisher, and registration date.

## Features
- Stores information such as the book title, author’s first name, author’s last name, page count, and publisher.
- The **Registration Date** is automatically assigned when the book is registered.
- Two different **constructors** (methods for object creation) are available to create book objects:
  - **Default Constructor**: A parameterless constructor that automatically assigns only the registration date when a new book is created.
  - **Parameterized Constructor**: Takes the book title, author’s name, page count, and publisher as parameters and assigns them when a book object is created.

## Usage

### 1. Creating a Book Object (Parameterized Constructor):

```csharp
Book kitap2 = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
kitap2.KitabiTanit();
```

### 2. Creating a Book Object (Default Constructor):

```csharp
Book kitap1 = new Book();
kitap1.Name = "Yeni Kitap Adı";
kitap1.AuthorsName = "Yazar Adı";
kitap1.AuthorsSurName = "Yazar Soyadı";
kitap1.TotalPage = 0;
kitap1.Publisher = "Yayınevi";
kitap1.KitabiTanit();  // Prints book details to the console
```

---

### **Conclusion:**
This application is designed to help you understand key object-oriented programming (OOP) concepts such as **class**, **constructor**, **property**, and the **new** keyword. The book registration application can be expanded with more features and customizations.

---

This version of the README file explains the project, its features, and usage in English, making it accessible to a wider audience.