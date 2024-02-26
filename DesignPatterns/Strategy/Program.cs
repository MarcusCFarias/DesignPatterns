

using Strategy;

Console.WriteLine("Strategy Pattern!!!");

Duck rubberDuck = new RubberDuck();
Duck mallardDuck = new MallardDuck();

rubberDuck.Display();
rubberDuck.Flying();
rubberDuck.Quacking();

mallardDuck.Display();
mallardDuck.Flying();
mallardDuck.Quacking();

//change the behavior on run time
mallardDuck.SetFlyBehavior(new FlyNoWay());
mallardDuck.Flying();