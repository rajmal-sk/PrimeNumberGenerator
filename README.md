# PrimeNumberGenerator

## Overview
PrimeNumberGenerator is a simple application built using C# to generate prime numbers up to a given limit.

## Prerequisites
- Install [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) to build and run the project.

## Installation & Running the Application
1. ### Clone the repository:
   ```sh
   git clone https://github.com/rajmal-sk/PrimeNumberGenerator.git
   cd PrimeNumberGenerator

2. ### Build the Project
  
   Navigate to the PrimeNumberGenerator folder and execute the below command.<br>
   ```sh
   dotnet build

3. ### Running the Application

    #### Windows

    After building, run:
    ```sh
    dotnet run
    ```

    #### Linux/macOS

    The build process generates a DLL file. To run the application:
    ```sh
    cd bin/Debug/net8.0/
    dotnet PrimeNumberGenerator.dll
    ```

4. ### Usage

    The program will prompt you to enter a number.

    Enter an integer greater than 1 to generate prime numbers up to that limit.

    Type quit to exit the program.

