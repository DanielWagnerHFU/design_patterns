# Design Patterns

This project contains information about software design patterns. 
There will be code examples and templates for different object-oriented programming languages.
I will also try to add information about pros and cons, and the overall use of the design patterns in code comments or readme files.
The focus is to find the perfect implementation for each programming language. 

## Installation

Well you can just copy and paste the code parts in your projects. No installation is needed. 

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
Please make sure to update tests as appropriate.

## Status

### Creational patterns

| Name                                          | Description                                                                                                                                                                                                                                                 | C# | Java | C++ |
|-----------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----|------|-----|
| Singleton                                     | Ensure a class has only one instance, and provide a global point of access to it.                                                                                                                                                                           | 3  | 0    | 0   |
| Resource acquisition is initialization (RAII) | Ensure that resources are properly released by tying them to the lifespan of suitable objects.                                                                                                                                                              |    |      |     |
| Prototype                                     | Specify the kinds of objects to create using a prototypical instance, and create new objects from the 'skeleton' of an existing object, thus boosting performance and keeping memory footprints to a minimum.                                               |    |      |     |
| Object pool                                   | Avoid expensive acquisition and release of resources by recycling objects that are no longer in use. Can be considered a generalisation of  connection pool and  thread pool patterns.                                                                      |    |      |     |
| Multiton                                      | Ensure a class has only named instances, and provide a global point of access to them.                                                                                                                                                                      |    |      |     |
| Lazy initialization                           | Tactic of delaying the creation of an object, the calculation of a value, or some other expensive process until the first time it is needed. This pattern appears in the GoF catalog as "virtual proxy", an implementation strategy for the  Proxy pattern. |    |      |     |
| Factory method                                | Define an interface for creating a  single object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.                                                                                     |    |      |     |
| Dependency Injection                          | A class accepts the objects it requires from an injector instead of creating the objects directly.                                                                                                                                                          |    |      |     |
| Builder                                       | Separate the construction of a complex object from its representation, allowing the same construction process to create various representations.                                                                                                            |    |      |     |
| Abstract factory                              | Provide an interface for creating  families of related or dependent objects without specifying their concrete classes.                                                                                                                                      |    |      |     |

### Structural patterns

| Name      | Description                                                                       | C# | Java | C++ |
|-----------|-----------------------------------------------------------------------------------|----|------|-----|
|           |                                                                                   |    |      |     |
|           |                                                                                   |    |      |     |             

### Behavioral patterns

| Name      | Description                                                                       | C# | Java | C++ |
|-----------|-----------------------------------------------------------------------------------|----|------|-----|
| Observer  | Define a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically.                                                                                  | 3  | 0    | 0   |
|           |                                                                                   |    |      |     |

### Concurrency patterns

| Name      | Description                                                                       | C# | Java | C++ |
|-----------|-----------------------------------------------------------------------------------|----|------|-----|
|           |                                                                                   |    |      |     |
|           |                                                                                   |    |      |     |

## License
[GNU](http://www.gnu.de/documents/gpl-3.0.en.html)