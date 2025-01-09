# Encapsulation: Car Class

## Project Overview

This project demonstrates the concept of **Encapsulation** in Object-Oriented Programming (OOP) by creating a `Araba` class with properties such as `Marka`, `Model`, `Renk`, and `KapiSayisi`. We focus on encapsulating the `KapiSayisi` property to ensure that only valid values (2 or 4) are assigned to it.

If an invalid value is assigned to the `KapiSayisi`, a warning message will be displayed on the console, and the `KapiSayisi` will be set to **`-1`**.

## Features

- **Properties**: The `Araba` class includes the following properties:
  - `Marka`: The brand of the car.
  - `Model`: The model of the car.
  - `Renk`: The color of the car.
  - `KapiSayisi`: The number of doors the car has. Only valid values (2 or 4) are accepted.
  
- **Encapsulation**: The `KapiSayisi` property is encapsulated with validation. If a value other than 2 or 4 is assigned, it triggers a console warning, and the value is set to **-1**.

## Instructions

### **Araba Class Implementation**

```csharp
public class Araba
    {
        private int kapiSayisi;// Private field for encapsulation

        public int KapiSayisi
        {
            get
            {
                return kapiSayisi;
            }
            set
            {
                // If the value is not 2 or 4, set doorCount to -1 and display a warning
                if (value == 2 || value == 4)
                {
                    kapiSayisi = value;

                }
                else
                {
                    kapiSayisi = -1;
                    Console.WriteLine("Girilen değerde bir kapı sayısı yoktur. Yanlış girdi.");
                }

            }
        }
        // Other properties
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }

        public Araba() // Constructor
        {
            KapiSayisi = 4; // Default value for KapiSayisi
        }

        // Constructor with parameters
        public Araba(string model, string marka, string renk, int kapiSayisi)
        {
            Model = model;
            Marka = marka;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }

        public void ArabayiTanit()
        {
            Console.WriteLine($"{Model} model arabanın markası {Marka}, rengi {Renk}");
        }

        public void KapiSayisiniSoyle()
        {
            if (kapiSayisi != -1)
                Console.WriteLine($"Kapı Sayısı: {kapiSayisi}");
        }

    }
```

### **Example Usage**

```csharp
// Creating an Araba object using the default constructor
Araba araba1 = new Araba();
Console.WriteLine($"Car1 - Door Count: {car1.DoorCount}");  

// Creating an Araba object with parameters
Araba araba2 = new Araba("Toyota", "Corolla", "Red", 4);
Console.WriteLine($"Car2 - Marka: {araba2.Marka}, Kapı Sayısı: {araba2.KapiSayisi}");  

// Attempting to assign an invalid door count (will trigger warning)
Car car3 = new Car("Honda", "Civic", "Blue", 3);  // Invalid door count
Console.WriteLine($"Car3 - Door Count: {car3.DoorCount}");  // Door Count: -1 (Invalid)
```

### **Encapsulation Explanation**

- **Private Field**: The `kapiSayisi` field is declared as `private` to encapsulate it. This prevents direct access to the field from outside the class.
  
- **Property with Validation**: The `KapiSayisi` property is used to control access to the `kapiSayisi` field. The **setter** ensures that only valid values (2 or 4) are assigned to `kapiSayisi`. If an invalid value is assigned, the **getter** will return **`-1`**, and a warning will be displayed.

- **Warning Message**: When an invalid value is entered (i.e., any value other than 2 or 4), a message is displayed:  
  `Invalid door count. Valid options are 2 or 4.`


## Objective

This project demonstrates the core concept of **encapsulation** by using **properties** in C#. It controls how data is accessed and modified within a class. In this case, we encapsulate the `KapiSayisi` property to ensure that only specific, valid values are allowed for the car's door count.

### **Key Concepts Used:**
- **Class**: `Araba` class representing a car with attributes.
- **Property**: `KapiSayisi` property for encapsulating and validating the number of doors.
- **Constructor**: To initialize the car with specific properties.
- **Encapsulation**: Hiding the private field `kapiSayisi` and providing controlled access via a public property.

---

This **README** explains the goal of the project, the key concepts of **encapsulation**, and the implementation details, providing a comprehensive guide for understanding the purpose and usage of the `Araba` class.