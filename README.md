# _Eau Claire's Salon_

#### _ASP.NET Database Basics Project for Epicodus_, _March 2020_

#### By _**K Wicz**_

![Landing Page Preview](/HairSalon/wwwroot/img/splash-page.png)

## Description

_An MVC web application to help a salon owner manage her employees (stylists) and their clients.._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
|User can can choose to add a new stylist| "Esme Gigi Genevieve Squalor"| "Esme Gigi Genevieve Squalor" is added to the stylist database|
|User can view all stylists|Selects "view all"|All stylists in the stylist table of the database are printed to the page|
|User can view all clients of each stylist|Clicks "Esme Gigi Genevieve Squalor"|All clients that belong to "Esme Gigi Genevieve Squalor" are displayed.|
|User can edit added stylists|"Esme Gigi Genevieve Squalor" --> "Stefano"|"Esme Gigi Genevieve Squalor" is updated to "Stefano" in the stylist table|
|User can delete stylists|User selects "Delete" from options on "Stefano" Details page|"Stefano" is removed from the stylists table.|
|User can add a new client and specify which stylist it belongs to, as well as other client details.|"Miriam "Midge" Maisel", "Stefano"|"Mrs. Maisel" is added to the clients table, with the idea of the specified stylist in a stylist column.|
|User can view all clients|Selects "view all"|User can see all clients listed in the clients table.|
|User can edit clients|"Miriam "Midge" Maisel" --> "Susie Myerson"|"Miriam "Midge" Maisel" is updated to "Susie Myerson" in the restaraunt table.|
|User can delete clients|User selects "Delete"|The row with "Susie Myerson" is removed from the clients table.|
|User can enter a query to search existing stylists |User enters "Stefano"| Search results return a list of stylists with the term "Stefano"|


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
git clone https://github.com/kwicz/HairSalon.Solution
cd HairSalon.Solution
```

### 3. Create Project Database
* Navigate to your terminal and open MySQL
```sh
mysql -uroot -p<your_password_here>
```
* Once in MySQL, create a database for storing project data:
```sh
CREATE DATABASE `k_wicz`;
USE 'k_wicz';
```
* Create a table in k_wicz for storing stylist data:
```sh
CREATE TABLE `k_wicz`.`stylists` (
  `stylistid` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `hiredate` VARCHAR(45) NULL,
  `speciality` VARCHAR(45) NULL,
  PRIMARY KEY (`stylistid`));
```
* Create a table in hair_salon for storing client data:
```sh
CREATE TABLE `k_wicz`.`clients` (
  `clientid` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `notes` VARCHAR(255) NULL,
  `stylistid` INT NULL DEFAULT 0,
  PRIMARY KEY (`clientid`));
```
### 4. Launch the project
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd HairSalon
dotnet restore
dotnet build
dotnet watch run
```

Voila! The project is now ready.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/hairsalon.solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL_
* _EF Core 2.2.6_
* _Razor 2.2.0_
* _Material Lite_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K Wicz_**