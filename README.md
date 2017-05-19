# BudgetTracker - C# Refresher

## Author

Brandon Rodriguez

## Description

### Purpose

The actual purpose of this program wasn't so much for the functionality, so much as an excuse to write in C# again.

Before this project, it had been roughly two years since I had programmed anything in C#.

I figured it was time to pick the language back up, refresh myself on all previous concepts, and implement concepts learned since I'd last used C#.

### Functionality

At it's core, the scope of functionality for this program is rather small.

It's simply meant to keep a list of people/businesses, as well as the associated transactions between them.

Transactions can be one-time or reocurring.

## Current Implementation

Uses Singletons, Interfaces, CompareTo, Generics, custom DoublyLinked LinkedLists, Forms, and more.

Has thorough unit testing for all classes, excluding the form and controller.

Has validation every step of the way, including both within the models and in the UI.

## ToDo

Currently missing:

* Database connection to make all data permanent.
* Front end implementation of transactions.
* Front end implementation of transactor editing/deleting.
* Unit testing of front end.
* Unit testing of controller class.
