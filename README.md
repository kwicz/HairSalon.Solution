# _Eau Claire's Salon_

#### _ASP.NET Database Basics Project for Epicodus_, _March 2020_

#### By _**K Wicz**_

![Landing Page Preview](/EauClairesSalon/wwwroot/img/splash-page.png)

## Description

_An MVC web application to help a salon owner manage her employees (stylists) and their clients.._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|User can can choose to add a new cuisine| "Mongolian Street Food"| "Mongolian Street Food" is added to the cuisine database|
|User can view all cuisines|Selects "view all"|All cuisines in the cuisine table of the database are printed to the page|
|User can view all restaurants of each cuisine|Clicks "Mongolian Street Food"|All restaurants that serve "Mongolian Street Food" are displayed.|
|User can edit added cuisines|"Mongolian Street Food" --> "Szechuan Street Food"|"Mongolian Street Food" is updated to "Szechuan Street Food" in the cuisine table|
|User can delete cuisines|User selects "Delete" from options on "Szechuan Street Food" Details page|"Szechuan Street Food" is removed from the cuisines table.|
|User can add a new restaurant and specify which cuisine it belongs to, as well as other restaurant details.|"Lucky Strike", "Szechuan Street Food"|"Lucky Strike" is added to the restaurants table, with the idea of the specified cuisine in a cuisine column.|
|User can view all restaurants|Selects "view all"|User can see all restaurants listed in the restaurants table.|
|User can edit restaurants|"Lucky Strike" --> "Unlucky Cat"|"Lucky Strike" is updated to "Unlucky Cat" in the restaraunt table.|
|User can delete restaurants|User selects "Delete"|The row with "Unlucky Cat" is removed from the restaurants table.|
|User can enter a query to search existing cuisines |User enters "Thai"| Search results return a link to Thai cuisine, which then can take the user to all thai restaurants |


## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/kwicz/EauClairesSalon.Solution
cd EauClairesSalon.Solution
```

### 3. Create Project Database
* Navigate to your terminal and open MySQL
```sh
mysql -uroot -p<your_password_here>
```
* Once in MySQL, create a database for storing project data:
```sh
CREATE DATABASE `hair_salon`;
```
* Create a table in hair_salon for storing stylist data:
```sh
CREATE TABLE `stylists` (
  `stylistid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `hire_date` datetime DEFAULT NULL,
  `speciality` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stylistid`));
```
* Create a table in hair_salon for storing client data:
```sh
CREATE TABLE `clients` (
  `clientid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `notes` varchar(255) DEFAULT NULL,
  `stylistid` int(11) DEFAULT '0',
  PRIMARY KEY (`clientid`));
```
### 4. Launch the project
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd EauClairesSalon
dotnet restore
dotnet build
dotnet watch run
```

Voila! The project is now ready.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/eauclairessalon.solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL_
* _EF Core_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K Wicz_**