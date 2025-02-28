## Principles of Programming Applied

This project follows multiple programming principles to ensure maintainability, readability, and efficiency.

### 1. DRY (Don't Repeat Yourself)

- The `Money` class centralizes currency-related logic, avoiding redundant currency calculations across different classes ([Money.cs]https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Money.cs)).
- The `Reporting` class provides a reusable method `InventoryReport()` to display inventory status ([Reporting.cs](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Reporting.cs)).

### 2. KISS (Keep It Simple, Stupid)

- The class structures are straightforward, avoiding unnecessary complexity.
- The `Warehouse` class provides simple methods for adding and displaying products without over-engineering ([Warehouse.cs](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Warehouse.cs)).

### 3. SOLID Principles

#### S - Single Responsibility Principle (SRP)

- Each class has a single responsibility:
  - `Money` handles currency operations.
  - `Product` manages product-related logic.
  - `Warehouse` stores product lists.
  - `Reporting` handles inventory reports.

#### O - Open/Closed Principle (OCP)

- New product types or currencies can be introduced without modifying existing classes.
- Example: To add a new `DiscountedProduct`, we can extend `Product` rather than modifying it.

#### L - Liskov Substitution Principle (LSP)

- Future extensions of `Product` will work seamlessly wherever `Product` is used.
- Example: `DiscountedProduct : Product` would still function with `Warehouse`.

#### I - Interface Segregation Principle (ISP)

- While no explicit interfaces are used, responsibilities are kept separate, preventing bloated classes.

#### D - Dependency Inversion Principle (DIP)

- The `Warehouse` class depends on `Product`, but we could introduce an interface `IProduct` for better decoupling.

### 4. YAGNI (You Ain't Gonna Need It)

- Only necessary methods are implemented; unnecessary features (like extensive validation) are omitted.

### 5. Composition Over Inheritance

- `Product` uses `Money` instead of inheriting from a base class like `FinancialEntity`, promoting composition.

### 6. Program to Interfaces, not Implementations

- Currently, the design supports easy future modifications by introducing interfaces for `Product` or `Warehouse`.

### 7. Fail Fast

- The `DecreasePrice` method ensures no negative price calculations by handling cents properly ([`Product.cs`]https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Product.cs)).

## File References

- [`Money.cs`](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Money.cs)
- [`Product.cs`](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Product.cs)
- [`Warehouse.cs`](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Warehouse.cs)
- [`Reporting.cs`](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/ClassLibrary/Reporting.cs)
- [`Program.cs`](https://github.com/Mirariel/Software-design/blob/master/Lab1/Software-designLab1/Software-designLab1/Program.cs)
