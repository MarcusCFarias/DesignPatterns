

using Observer;

Console.WriteLine("Observer Pattern!\n\n");

var provider = new WheaterProvider();
var monitor1 = new WheaterMonitor();
var monitor2 = new WheaterMonitor();

monitor1.Subscribe(provider);
monitor2.Subscribe(provider);

provider.GetWheater();

monitor1.Unsubscribe();

provider.GetWheater();
provider.GetWheater();
provider.GetWheater();