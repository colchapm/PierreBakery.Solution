# Pierre's Bakert

### Epicodus Independent Code Review - Test-Driven Development with C#

### By Collin Chapman

## Technologies Used

* Git
* C#
* .NET 5.0
* Bootstrap
* MSTest

## Description

This is a C# console application for Pierre's Bakery. This basic application runs and greets and informs them of prices and current specials. It lets them order loaves and bread and pastries. Based on these inputs, it returns a total order amount.

* Allow the user to choose number of loaves and number of pastries they wish to order
* Using a Bread class and a Pastry class separately, it calculates the total of each item
* If the user's ordered quantity takes advantage of the current specials, their orders are discounted appropriately. 

## Setup/Installation Requirements

* _Open the terminal on your local machine_
* _Navigate to the directory inside of which you wish to house this project_
* _Clone this project with the following command  `$ git clone <https://github.com/colchapm/PierreBakery.Solution.git>`_
* _Navigate to the test level of the repository with the command `$ cd PierreBakery.Tests`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Compile and run the application with the command `$ dotnet run`_

## Specificatons

| Behavior | Input | Output |
|:---: |:---:|:---:|
| The program should successfully create a Bread object | When it instantiates a new Bread constructor | Return type Bread|
| The program should return the order value of 1 loaf of bread | When it receives 1 | It should return 5|
| The program should return the order value of 2 loaves of bread | When it receives 2 | It should return 10|
| The program should return the number of loaves the user receives when they take advantage of the special offer | When it receives 2 | It should return 3|
| The program should successfully create a Pastry object | When it instantiates a new Pastry constructor | Return type Pastry|
| The program should return the order value of 1 pastry| When it receives 1 | It should return 2|
| The program should return the order value when the user takes advantage of the special offer | When it receives 3 | It should return 5|


## Known Bugs

No known bugs at this time

## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Collin Chapman

This software is licensed under the MIT license

## Contact Information

cchap14@gmail.com