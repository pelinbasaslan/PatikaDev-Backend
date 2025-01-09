

# Product Management System

This project simulates a product management system for a technology store. It manages two types of products: **Telefon** (Phone) and **Bilgisayar** (Computer). The system allows users to create new products, input their details, and validate certain conditions based on product properties.

### Features:
- **BaseMachine Class**: A base class containing common properties such as `ProductionDate`, `SerialNumber`, `Name`, `Info`, and `OperationSystem`.
- **Inheritance**: Both **Telefon** (Phone) and **Bilgisayar** (Computer) classes inherit from the `BaseMachine` class.
- **Polymorphism**: The `PrintInfo` method is overridden in the derived classes to print information specific to each product type.
- **Abstraction**: The `PrintTheNameOfProduct` method is abstract and is implemented in each derived class to print the respective product type ("Telefon" or "Bilgisayar").
- **Encapsulation**: Properties like `USBPortCount` (for **Bilgisayar**) and `TRLisans` (for **Telefon**) are encapsulated to ensure valid input and provide appropriate messages.

### How It Works:
1. **User Prompt**: The system prompts the user to choose between creating a **Telefon** (Phone) or a **Bilgisayar** (Computer) by pressing `1` or `2`.
2. **User Input**: Based on the user's choice, the system requests specific information for the product (e.g., `Name`, `Info`, `OperationSystem`, `SerialNumber`, etc.).
3. **Validation**:
   - **USB Port Count**: For **Bilgisayar**, only valid values of `2` or `4` for the `USBPortCount` are allowed; otherwise, `-1` is assigned.
   - **TRLisans (TR License)**: For **Telefon**, the system checks if the phone is licensed in Turkey and displays an appropriate message.
   - **Bluetooth**: For **Bilgisayar**, the user is asked if Bluetooth support is available.
4. **Success Message**: Once the product details are filled, the system confirms the product has been successfully created.
5. **Repeat Process**: The user is then asked if they want to create another product. If the answer is "Yes" (`E`), the program repeats the process. If the answer is "No" (`H`), the program ends.

---

## Code Explanation

### Classes and Inheritance:
- **BaseMachine Class**:
  - This is the base class that holds common properties (`ProductionDate`, `SerialNumber`, `Name`, `Info`, `OperationSystem`).
  - The `PrintInfo` method prints general information about the product.
  - The `PrintTheNameOfProduct` method is abstract and must be implemented by the derived classes.

- **Telefon Class**:
  - Inherits from `BaseMachine`.
  - Includes a `TRLisans` property that checks if the phone is licensed in Turkey.
  - The `PrintTheNameOfProduct` method is implemented to print "Telefon".

- **Bilgisayar Class**:
  - Inherits from `BaseMachine`.
  - Includes properties for `USBPortCount` and `Bluetooth`, both with encapsulation.
  - The `PrintTheNameOfProduct` method is implemented to print "Bilgisayar".

### Properties:
- **ProductionDate**: Automatically set to the current date and time when a new object is created.
- **SerialNumber**, **Name**, **Info**, **OperationSystem**: Properties for storing the serial number, name, description, and operating system of the product.
- **TRLisans**: A property for checking whether a **Telefon** is licensed in Turkey.
- **USBPortCount**: A property for storing the number of USB ports on a **Bilgisayar**. Valid values are `2` or `4`, otherwise, it defaults to `-1`.
- **Bluetooth**: A property for checking if a **Bilgisayar** has Bluetooth support.

### Methods:
- **PrintInfo**: Prints the details of the product including production date, serial number, name, description, and operating system.
- **PrintTheNameOfProduct**: An abstract method in `BaseMachine`, overridden in derived classes to print the type of product ("Telefon" or "Bilgisayar").

---

## Example Run

### Step 1: Choose Product Type

```
Press 1 to create a Telefon or press 2 to create a Bilgisayar:
```

### Step 2: Enter Product Details

- For **Telefon**:
  ```
  Enter the name of the phone: iPhone 13
  Enter the phone information: Latest iPhone model
  Enter the operating system: iOS 15
  Enter the serial number: A123456789
  Is the phone licensed in Turkey? (Y/N): Y
  ```

- For **Bilgisayar**:
  ```
  Enter the name of the computer: MacBook Pro 2021
  Enter the computer information: Latest MacBook model
  Enter the operating system: macOS Big Sur
  Enter the serial number: C987654321
  Does the computer have Bluetooth? (Y/N): Y
  How many USB ports? (Enter 2 or 4): 4
  ```

### Step 3: Product Information Display

```
Telefon details:
Turkey Licensed: Yes
Production Date: [current date]
Serial Number: A123456789
Name: iPhone 13
Info: Latest iPhone model
Operating System: iOS 15

Product successfully created. Would you like to create another product? (Y/N):
```

- After the user finishes, the program will ask if they want to create another product or exit the program.

---

## Technologies Used:
- **C#**: The primary language used for implementing the system.
- **Object-Oriented Programming**: Utilizes principles such as inheritance, polymorphism, abstraction, and encapsulation.

---

## How to Run:

1. Clone or download the repository.
2. Open the project in Visual Studio or any C# IDE.
3. Build and run the project.
4. Follow the on-screen prompts to create a **Telefon** or **Bilgisayar**.

---

## Conclusion:
This product management system provides a basic structure for managing different types of electronic products using Object-Oriented Programming concepts. It ensures that all necessary properties are captured, validated, and displayed in a user-friendly manner.