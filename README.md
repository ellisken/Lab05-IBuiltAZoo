# Lab05-IBuiltAZoo
A series of class definitions in C# for practicing inheritance, abstraction, and polymorphism. The classes can be used to implement a "zoo" of animal objects.

There is one abstract base class, Mammal, from which all other classes descend. Please refer to the diagram below for details.

## Class Diagram
![class-diagram](./assets/ZooClasses.png)

## Explanation of OOP Principles and How They're Used in I Built A Zoo
* Encapsulation: the packaging of data members and methods that act on those members together under an access specifier (e.g., public, private, protected, etc.). 
  + An example of encapsulation in IBuiltAZoo is the default assignment to all concrete classes the access specifier "private." This means that Program.cs must define methods that both create objects and call methods on those objects in order to access the return value of those methods in the unit tests.
* Inheritance: allows classes to inherit properties and classes from other methods. The parent class is called the "Base" class, and any inheritors are referred to as descendants.
  + An example of inheritance in IBuiltAZoo is when the class Panda inherits the properties Name, Age, and methods Eats() and Sleeps() from the class Bear, which inherits its members from the class Mammal.
* Abstraction: Abstract classes are non-instantiable classes. Abstract classes can optionally include abstract properties or methods, which must be defined by descendants of the abstract class.
  + An example of abstraction in IBuiltAZoo is when Mammal is declared as abstract. This means that Mammal cannot be instantiated. Additionally, the method Eats() in Mammal is abstract, which means it must be defined in any class that inherits from Mammal, like Bear and Primate.
* Polymorphism: allows virtual properties and methods in base classes to be overridden in descendant classes. This means that, for example, a method of the same name in a descendant class may adopt its parent's implementation of the method OR override the implementation with a new behavior.
  + Polymorphism occurs in IBuiltAZoo when Primate introduces the new virtual property HasTail and virtual method Hangs(). Descendants of Primate (Lemur, Chimpanzee, and Proboscis) have the option to use the value or method definition from Primate, or override them. For example, Chimpanzee overrides Primate's value for HasTail, while none of the descendant classes overrides Primate.Hangs().
