
```markdown
# Geometrical Shapes Area Calculation (Polymorphism Example)

## Overview

This project demonstrates the use of **Polymorphism** in object-oriented programming (OOP) by calculating the area of different geometric shapes. The shapes involved are:
- **Square (Kare)**
- **Rectangle (Dikdörtgen)**
- **Right Triangle (Dik Üçgen)**

To handle these shapes in a structured way, we use a **Base Class** called `BaseGeometrikSekil`, which contains common properties (like width and height) and a method (`AlanHesapla()`) to calculate the area.

Each of the derived classes (`Kare`, `Dikdörtgen`, and `Ucgen`) will have their own implementations for calculating the area. 

### Key OOP Concepts
- **Inheritance**: All specific shape classes (Kare, Dikdörtgen, and Ucgen) inherit from the base class `BaseGeometrikSekil`.
- **Polymorphism**: Each derived class overrides the method `AlanHesapla()` to implement its specific area calculation formula.

## Classes and Methods

### `BaseGeometrikSekil` (Base Class)

This is the base class that contains common properties for all shapes:

- **Properties**:
  - `Genislik` (Width)
  - `Yukseklik` (Height)
  
- **Methods**:
  - `AlanHesapla()`: A general method to calculate the area, but it will be overridden in each derived class to handle specific shape calculations.

```csharp
public class BaseGeometrikSekil
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    public virtual int AlanHesapla()
    {
        int alan= Genislik * Yukseklik;
        return alan;
    }
}
```

### `Kare` (Square)

The `Kare` class inherits from `BaseGeometrikSekil`. It calculates the area as `Width * Height`.

```csharp
public class Kare : BaseGeometrikSekil
{
    public Kare(int kenar)
    {
        Genislik = kenar;
        Yukseklik = kenar;  // For a square, width = height
    }
}
```

### `Dikdörtgen` (Rectangle)

The `Dikdörtgen` class also inherits from `BaseGeometrikSekil`. The area is calculated using the formula `Width * Height`.


### `Ucgen` (Right Triangle)

The `Ucgen` class also inherits from `BaseGeometrikSekil`. The area is calculated using the formula `(Width * Height) / 2`.

```csharp
public class Ucgen : BaseGeometrikSekil
{
    public Ucgen(){}

    // Area calculation for right triangle
    public override int AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2;
    }
}
```

### Example Usage

Here’s how you can create objects for each shape, calculate the area, and print the results:

```csharp
class Program
{
    static void Main(string[] args)
    {
        BaseGeometrikSekil kare = new Kare(2); 
        Console.WriteLine("Karenin alanı: " + kare.AlanHesapla());

        Kare kare2 = new Kare(5);
        Console.WriteLine("Kare 2nin alanı: " + kare2.AlanHesapla()); 

        BaseGeometrikSekil dikdortgen = new Dikdortgen();
        dikdortgen.Yukseklik = 2;
        dikdortgen.Genislik = 6;
        Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen.AlanHesapla());

        BaseGeometrikSekil ucgen = new Ucgen();
        ucgen.Yukseklik = 3;
        ucgen.Genislik = 6;
        Console.WriteLine("Üçgenin alanı: " + ucgen.AlanHesapla());
    }
}
```

### Expected Output:

```
Karenin alanı: 4
Kare2nin alanı: 25
Dikdörtgenin alanı: 12
Üçgenin alanı: 9
```

## How It Works

### 1. **Inheritance**

- The `Kare`, `Dikdörtgen`, and `Ucgen` classes inherit from the `BaseGeometrikSekil` class. This allows them to share common properties (`Genislik` and `Yukseklik`) and the method `AlanHesapla()`.
  
### 2. **Polymorphism**

- Instead of using a single method in the base class, each derived class (e.g., `Kare`, `Dikdörtgen`, `DikUcgen`) implements its own version of `AlanHesapla()` to calculate the area according to the shape's formula.
- This is an example of **polymorphism**, where the same method name (`AlanHesapla`) behaves differently depending on the object type (whether it's a square, rectangle, or triangle).

### 3. **Creating Objects**

- Objects for `Kare`, `Dikdörtgen`, and `DikUcgen` are instantiated with specific values for width and height.
- The area calculation for each shape is done by calling the overridden `AlanHesapla()` method for each object.

---

## Conclusion

This project demonstrates the core concept of **Polymorphism** in OOP by allowing different geometric shapes to use a common method for area calculation, each with its own specific implementation. The use of inheritance and method overriding provides a clear and efficient way to handle various shapes and their calculations, promoting code reuse and flexibility.

---

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

```

This `README.md` provides an overview of the project, including a detailed explanation of inheritance, polymorphism, and how the code works. It also includes a sample usage section with expected output. You can add more details or expand on this as needed for your project!