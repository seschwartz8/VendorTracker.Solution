# Vender and Order Tracker

![LastCommit](https://img.shields.io/github/last-commit/seschwartz8/VenderTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/seschwartz8/VenderTracker.Solution)
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

A C#/.NET Core MVC website that allows you to see all bakery venders and their orders. This project was built for Epicodus's independent Friday project with a focus on using objects within objects, MVC routes, and REST conventions.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the VenderTracker directory, within the VenderTracker.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Specs

- User will be welcomed by a splash page.
  - Sample input: User inputs URL of website
  - Expected output: Splash page appears
- User can see all venders
  - Sample input: User clicks on link within spash page to view venders
  - Expected output: New page with all venders listed appears
- User can create a new vender
  - Sample input: User clicks on link within venders page to create vender
  - Expected output: New page with form appears
- When user submits new vender, he is taken back to splash page and vender is saved
  - Sample input: User clicks submit on vender form
  - Expected output: Splash page reappears, and if user views venders again the new one is present
- User can click a specific vender's name to see all of their orders
  - Sample input: User clicks on vender's name (e.g. "Tall Grass Baking")
  - Expected output: New page with information on all of Tall Grass Baking's orders appears (e.g. 2 croissants, 3 loaves)
- User can add orders to specific venders
  - Sample input: User clicks on link within specific vender page to add order
  - Expected output: New page with form to add order appears
- When user submits new order, he is taken back to specific vender's page
  - Sample input: User clicks submit on order form
  - Expected output: Specific vender page reappears with new order present
- User can delete all venders
  - Sample input: User clicks on button to delete all within viewing venders page
  - Expected output: All venders are removed and page notifies user they have no venders

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
