# Calculator Application with NUnit Tests

## Overview
This project contains a simple Calculator application implemented in C#. The project includes unit tests written using NUnit to validate the application's functionality.

## Prerequisites
1. Visual Studio installed on your machine.
2. .NET Framework or .NET Core SDK installed.
3. NUnit and NUnit3TestAdapter installed via NuGet.

## Setup and Running Instructions

### 1. Clone or Download the Repository
- Clone this repository or extract the provided ZIP file.

### 2. Install Dependencies
- Open the solution in Visual Studio.
- Go to `Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution`.
- Install:
  - **NUnit**
  - **NUnit3TestAdapter**

### 3. Build the Solution
- Ensure the solution builds without errors by clicking on `Build -> Build Solution`.

### 4. Run Tests
- Go to `Test -> Test Explorer` in Visual Studio.
- Click `Run All` to execute all NUnit tests.

### 5. Expected Output
- All tests should pass successfully.
- If a test fails, descriptive error messages will help in debugging.

## Additional Notes
- The Calculator class includes basic arithmetic operations.
- Edge cases, such as division by zero, are handled with appropriate exceptions and tested thoroughly.

## Deliverables
- The entire project folder, including:
  - `Calculator.cs` (Application)
  - `CalculatorTests.cs` (Unit Tests)
  - `README.md` (Documentation)
