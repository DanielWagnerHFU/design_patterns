# Singleton

In software engineering, the singleton pattern is a software design pattern that restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system. The term comes from the mathematical concept of a singleton.

Critics consider the singleton to be an anti-pattern in that it is frequently used in scenarios where it is not beneficial, introduces unnecessary restrictions in situations where a sole instance of a class is not actually required, and introduces global state into an application.

[Source](https://en.wikipedia.org/wiki/Singleton_pattern)

## Possible uses

- Hardware interface access: The use of singleton depends on the requirements. However practically singleton can be used in case external hardware resource usage limitation required e.g. Hardware printers where the print spooler can be made a singleton to avoid multiple concurrent accesses and creating deadlock.

- Logger : Similarly singleton is a good potential candidate for using in the log files generation. Imagine an application where the logging utility has to produce one log file based on the messages received from the users. If there is multiple client application using this logging utility class they might create multiple instances of this class and it can potentially cause issues during concurrent access to the same logger file. We can use the logger utility class as a singleton and provide a global point of reference.

- Configuration File: This is another potential candidate for Singleton pattern because this has a performance benefit as it prevents multiple users to repeatedly access and read the configuration file or properties file. It creates a single instance of the configuration file which can be accessed by multiple calls concurrently as it will provide static config data loaded into in-memory objects. The application only reads from the configuration file at the first time and there after from second call onwards the client applications read the data from in-memory objects.

- Cache: We can use the cache as a singleton object as it can have a global point of reference and for all future calls to the cache object the client application will use the in-memory object.

[Source](https://dzone.com/articles/singleton-design-pattern-%E2%80%93)

## Pros

- Instance control: Singleton prevents other objects from instantiating their own copies of the Singleton object, ensuring that all objects access the single instance.
- Flexibility: Since the class controls the instantiation process, the class has the flexibility to change the instantiation process.
- Easy to implement: Easy to create and we could use it anywhere for the lifetime of the app The advantage of Singleton over global variables is that you are absolutely sure of the number of instances when you use Singleton. However, you can still change your mind and manage any number of instances. Having a very versatile design pattern that can work well for many different applications and processes.

[Source](https://why.workwithmad.com/pros-and-cons-of-singleton/)

## Cons

- They are a global mutable shared state. Their state is automatically shared across the entire app, and bugs can often start occurring when that state changes unexpectedly.
- The relationships between Singletons and the code that depends on them is usually not very well defined. Since Singletons are so convenient and easy to access — using them extensively usually leads to very hard to maintain “spaghetti code” that doesn’t have clear separations between objects.
- Managing their life-cycle can be tricky. Since Singletons are alive during the entire lifespan of an application, managing them can be really hard, and they usually have to rely on optionals to keep track of values. This also makes code that relies on Singletons really hard to test, since you can’t easily start from a “clean slate” in each test case. The disadvantages of Singleton over a global mutable shared state can give you a real headache if the state changes unexpectedly and also keep your code tightly coupled. It will make difficult to test when your code is not loosely coupled so it will cause a lot problems to maintain.

[Source](https://why.workwithmad.com/pros-and-cons-of-singleton/)

## Versions

### Singleton1 - best practise | thread safe & lazy

This template is the best practise for a singleton in C#. It is thread safe and uses lazy initialization.

### Singleton2 - one thread only

This template is a very simple singleton. It is not thread safe and should only be used if you know for sure, that only one thread will exist. 

### Singleton3 - thread safe

This is a template for a singleton which is thread safe and doesnt use the function Lazy (Like Singleton1). Instead it uses a lock. 

