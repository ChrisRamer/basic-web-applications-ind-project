# *Vendor & Order Tracker*

#### *Pierres Bakery, 3/5/2021*

#### By **Chris Ramer**

## Description

For my good friend Pierre to keep track of all your vendors and orders.

## Setup/Installation Requirements

Clone this repo to your PC.
Open it up in an IDE of your choice and open the terminal and navigate to the directory of the main project (`cd  "[where you stored project]\VendorsAndOrders\VendorsAndOrders.Solution"`).
Then in terminal, run the command `dotnet watch run` and click on the localhost:5000 link to load the site.

## Specs

* **Spec:** Adding a new vendor will store that vendor to a list of all vendors
* **Input:** Vendors with names: Elon Musk, Bill Nye, and Loki Laufeyson
* **Output:** Redirects to a page showing vendors Elon Musk, Bill Nye, and Loki Laufeyson with each linking to their respective page
* **Spec:** Adding a new order will store that order to a list of all orders for that vendor
* **Input:** Order for Elon Musk of a Tesla Model S for $69,420 (this is actual MSRP by the way)
* **Output:** Redirects to page showing the order for the  Tesla to Musk with price, description, and date

## Technologies Used

* C#
* MVC

### License

Copyright (c) 2021 **Chris Ramer**
This software is licensed under the MIT license.