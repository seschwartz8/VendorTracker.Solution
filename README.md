# Vendor and Order Tracker

![LastCommit](https://img.shields.io/github/last-commit/seschwartz8/VendorTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/seschwartz8/VendorTracker.Solution)
![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)

#### Epicodus Friday project with a focus on C#/.NET Core MVC, objects within objects, and RESTful routing, Current Version: 03.13.20

#### By Sarah "Sasa" Schwartz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

A C#/.NET Core MVC website that allows you to see all bakery vendors and their orders. This project was built for Epicodus's independent Friday project with a focus on using objects within objects, MVC routes, and REST conventions.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the VendorTracker directory, within the VendorTracker.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Specs

- User will be welcomed by a splash page.
  - Sample input: User inputs URL of website
  - Expected output: Splash page appears
- User can see all vendors
  - Sample input: User clicks on link within spash page to view vendors
  - Expected output: New page with all vendors listed appears
- User can create a new vendor
  - Sample input: User clicks on link within vendors page to create vendor
  - Expected output: New page with form appears
- When user submits new vendor, he is taken back to splash page and vendor is saved
  - Sample input: User clicks submit on vendor form
  - Expected output: Splash page reappears, and if user views vendors again the new one is present
- User can delete all vendors
  - Sample input: User clicks on button to delete all within viewing vendors page
  - Expected output: All vendors are removed and page notifies user they have no vendors
- User can click a specific vendor's name to see all of their orders
  - Sample input: User clicks on vendor's name (e.g. "Tall Grass Baking")
  - Expected output: New page with information on all of Tall Grass Baking's orders appears (e.g. 2 croissants, 3 loaves)
- User can add orders to specific vendors
  - Sample input: User clicks on link within specific vendor page to add order
  - Expected output: New page with form to add order appears
- When user submits new order, he is taken back to specific vendor's page
  - Sample input: User clicks submit on order form
  - Expected output: Specific vendor page reappears with new order present
- User can delete specific order
  - Sample input: While looking at specific order's details, user clicks "Delete This Order"
  - Expected output: Specific vendor page reappears with new order removed

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
