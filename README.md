# Polymorphism

The Polymorphism project is a console application that demonstrates the usage of interfaces and polymorphism in C#. It includes an interface called IQuittable that defines a method called Quit(). The Employee class from the previous drill is modified to inherit from the IQuittable interface and implements the Quit() method. The project utilizes polymorphism by creating an object of type IQuittable and calling the Quit() method on it.

# Project Description

The Polymorphism project consists of two files: IQuittable.cs and Employee.cs.

IQuittable.cs

This file contains the IQuittable interface, which includes the definition of the Quit() method. The interface allows classes to implement the Quit() method.

Employee.cs

This file contains the modified Employee class that inherits from the Person class and implements the IQuittable interface. The Employee class provides an implementation for the Quit() method defined in the IQuittable interface.

# Instructions

Start the console application.

The program will create an instance of the Employee class.

The Employee class inherits from the Person class and implements the IQuittable interface.

The program will call the Quit() method on the Employee object.

Observe the output or behavior defined in the implementation of the Quit() method in the Employee class.

The program will terminate.

You can rerun the program to create new instances of the Employee class and test the functionality.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to interfaces and polymorphism in C#:

Defining an interface

Implementing an interface in a class

Utilizing polymorphism with interface types

Calling methods on objects of interface types
