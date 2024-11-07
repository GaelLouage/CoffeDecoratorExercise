# Coffee Decorator Pattern in C#

This project demonstrates the **Decorator Design Pattern** in C#. It allows for adding additional features to a base coffee order dynamically, such as milk and sugar, without modifying the base coffee class.

## Table of Contents
- [Project Overview](#project-overview)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Design Pattern Explanation](#design-pattern-explanation)

---

## Project Overview

This application provides a simple way to customize coffee orders by adding different ingredients (like milk and sugar) dynamically. The project follows the Decorator Pattern, which allows wrapping the base coffee class with additional "decorators" to add functionality without altering the original code.

### Components
- **ICoffee**: Interface that defines `GetCost` and `GetDescription` methods for all coffee types.
- **SimpleCoffee**: Base coffee class implementing `ICoffee`, which returns a default description and price.
- **CoffeeDecorator**: Abstract base class for decorators, implementing `ICoffee`. This class wraps another `ICoffee` object.
- **MilkDecorator**: Concrete decorator for adding milk to the coffee, increasing cost and updating description.
- **SugarDecorator**: Concrete decorator for adding sugar to the coffee, increasing cost and updating description.

---

## Getting Started

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download) (recommended .NET 5.0 or newer)

### Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/CoffeeDecoratorPattern.git
