# Observer

The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.

It is mainly used to implement distributed event handling systems, in "event driven" software. In those systems, the subject is usually called a "stream of events" or "stream source of events", while the observers are called "sink of events". The stream nomenclature simulates or adapts to a physical setup where the observers are physically separated and have no control over the emitted events of the subject/stream-source. This pattern then perfectly suits any process where data arrives through I/O, that is, where data is not available to the CPU at startup, but can arrive "randomly" (HTTP requests, GPIO data, user input from keyboard/mouse/..., distributed databases and blockchains, ...). Most modern languages have built-in "event" constructs which implement the observer pattern components. While not mandatory most 'observers' implementations will use background threads listening for subject events and other support mechanism from the kernel (Linux epoll, ...)

[Source](https://en.wikipedia.org/wiki/Observer_pattern)

## Possible uses

- A one-to-many dependency between objects should be defined without making the objects tightly coupled.
- It should be ensured that when one object changes state an open-ended number of dependent objects are updated automatically.
- It should be possible that one object can notify an open-ended number of other objects.
- Model View Controller Pattern - The observer pattern is used in the model view controller (MVC) architectural pattern. In MVC the this pattern is used to decouple the model from the view. View represents the Observer and the model is the Observable object.
- Event management - This is one of the domains where the Observer patterns is extensively used. Swing and .Net are extensively using the Observer pattern for implementing the events mechanism.

## Pros

- Supports the principle to strive for loosley coupled designs between objects that interact.
- Allows you to send data to many other objects in a very efficient mannor.
- No modification is need to be done to the subject to add new observers.
- You can add and remove observers at anytime.

[Source](https://neillmorgan.wordpress.com/2010/02/07/observer-pattern-pros-cons/)

## Cons

- If not used carefully the observer pattern can add unecessary complexity
- The order of Observer notifications is undependable
- May result in many notifications the observers are not
interested in
- depending on the implementation it can mix code functionality with logic of the class. You can use a abstract class instead of a interface to remove this problem.

[Source](https://neillmorgan.wordpress.com/2010/02/07/observer-pattern-pros-cons/)

## Versions

### Observer1 - Simple implementation

This template showcases a really simple way to implement the Observer in C# using two interfaces.
