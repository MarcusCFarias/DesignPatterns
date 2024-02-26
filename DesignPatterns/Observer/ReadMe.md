### When to use:

It can be used when has to send some notification.
Observer defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
Principal components: data, observable and observer.


### Advantages:
- It supports the principle of loose coupling between objects that interact with each other
- It allows sending data to other objects effectively without any change in the Subject or Observer classes
- Observers can be added/removed at any point in time

### Disavantages:

- The Observer interface has to be implemented by ConcreteObserver, which involves inheritance. There is no option for composition, as the Observer interface can be instantiated.

### Example explained:

In my example, there is a provider in which sends notification about the wheater to the monitors. There is a interface for the CSharp implemented by microsoft, take a look. https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern