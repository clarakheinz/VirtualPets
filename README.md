# VirtualPets

## A fun console app game where you can make a virtual pet and interact with it.
___
### Code Louisville C# Project

As a part of Code Louisville curriculum, we are required to complete a project from complete scratch. I have chosen a *very* light version of a childhood PC game I loved. In this game, you can create a virtual pet, name it, feed it, and play with it (also, walk the pet *if* it is a dog). While it is not nearly as exciting (or visually appealing) as a real life pet, it is a much easier pet to care for!
____
**Game instructions:**

Upon starting the app up, a main menu will generate with instructions on how to make your selections. Each screen will show numbered options for you to choose from. Type in the corresponding number then hit enter for your selection to register.

Create a new pet or load up the test pet and begin playing!
_____
**Required features in this project:**
- Classes
    - 4 menu classes
    - Base class VirtualPet
    - 2 classes (Cat, Dog) that inherit from base class
- 3 methods created and called within the application
    - Several interaction methods within the virtual pets
    - Build methods for the different menues
- 3 additional features, outlined below

**Additional features included in this project:**
- Master loop:
    - All menu classes in the application feature a Do..While loop that allows for repeated user input and interaction
- Inheritance:
    - Dog and Cat inherit from VirtualPet. Cat does not vary from the base class, however, Dog has an additional method, Walk.
- Calculate data:
    - Inside of VirtualPet is a Calc_Age function which takes in today's date and creates a calculated age in days for the pet based on the datecreated field.
- Logging:
    - SavUtil provides a method to save the data of the pet in its current state. The data is serialized to JSON and saved to a file. 
- Reading data from file:
    - LoadUtil reads JSON file "savedGame" and deserializes to reinstate a pet object to continue game play. 

___
**Goals:**
- Create an About screen within app to explain the concept and inspiration of this project. 
- Create log of actions taken with pet
    - Based on log of actions, make suggestions on actions to take with pet
- Create 3 unit tests
- Add more visual elements to console app via ASCII art
