# Powers of Two - Bit Manipulation Approach

## Overview
This document explains how the following function efficiently determines whether a given integer is a power of two using bitwise operations:

```csharp
static string PowersofTwo(int num)
{
    return (num > 0 && (num & (num - 1)) == 0) ? "true" : "false";
}
```

## Explanation

### **1. Understanding the Concept**
A number is a power of two if it has only **one '1' bit** in its binary representation.

For example:
| Decimal | Binary  |
|---------|---------|
| 1       | 0001    |
| 2       | 0010    |
| 4       | 0100    |
| 8       | 1000    |
| 16      | 0001 0000 |

### **2. `(num & (num - 1)) == 0` Check**
This operation checks if `num` contains only **one '1' bit**.

#### **How does it work?**
1. `num - 1` flips the **rightmost '1' bit** to '0' and sets all bits to the right of it to '1'.
2. Performing `num & (num - 1)` **clears the only '1' bit**, resulting in `0` if `num` is a power of two.

#### **Example 1: 8 (2³) - Valid Power of Two**
```
num     =  8  →  1000  (Binary)
num - 1 =  7  →  0111  (Binary)
----------------------
num & (num - 1) = 0000 ✅
```
Since the result is `0`, **8 is a power of two**.

#### **Example 2: 10 - Not a Power of Two**
```
num     = 10  →  1010  (Binary)
num - 1 =  9  →  1001  (Binary)
----------------------
num & (num - 1) = 1000 ❌
```
Since the result is **not `0`**, **10 is not a power of two**.

### **3. `num > 0` Check**
We include `num > 0` to handle edge cases:
- **Negative numbers** cannot be powers of two.
- **Zero (`0`)** is not a power of two.

### **4. Performance Benefits**
✔ **Extremely fast** – uses **bitwise operations** instead of expensive mathematical computations.
✔ **No floating-point precision issues** (compared to logarithm-based methods).
✔ **Works for large numbers** efficiently.

## **Summary**
```csharp
static string PowersofTwo(int num)
{
    return (num > 0 && (num & (num - 1)) == 0) ? "true" : "false";
}
```
🔹 **Best way to check if a number is a power of two in C#!** 🚀

