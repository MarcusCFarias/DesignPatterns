### When to use:

The Strategy Pattern is used when you want to define a family of algorithms, encapsulate each algorithm, and make them interchangeable. It allows the client to choose the appropriate algorithm at runtime without altering its structure.

- a class defines many behaviors, and these appear as multiple conditional statements its operations. Instead of many conditionals, move related conditional branches into their own Strategy class.
- an algorithm uses data thtat clients shouldn't know about. Use the strategy pattern to avoid exposing complex logics.


### Advantages:

- Promotes Open/Closed Principle, Code Reusability
- Simplifies Testing
- Encapsulation

### Disavantages:

- Increased Number of Classes
- Complexity for simple algorithms
- Client's Awareness of strategies

### Example explained:

In my example, there is different classes of ducks whichs implement their own algorithm. 
For example, there is a abstract duck class which implements differents behaviors with composition, and then other types of ducks can implement their own logic.

