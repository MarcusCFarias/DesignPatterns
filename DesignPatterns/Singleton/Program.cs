using Singleton;

/*YOU HAVE TO TEST ONE AT TIME*/

Console.WriteLine("-------NORMAL SINGLETON------");

MultiThreadTesting.Test0();
MultiThreadTesting.Test1();

Console.WriteLine("-------NORMAL SINGLETON------\n");

//Console.WriteLine("-------NORMAL SINGLETON WITH MULTIPLE THREADS------");

//Parallel.Invoke(
//    () => MultiThreadTesting.Test0(),
//    () => MultiThreadTesting.Test1()
//);

//Console.WriteLine("-------NORMAL SINGLETON WITH MULTIPLE THREADS------\n");

//Console.WriteLine("-------THREAD SAFE SINGLETON------");

//MultiThreadTesting.Test2();
//MultiThreadTesting.Test3();

//Console.WriteLine("-------THREAD SAFE SINGLETON------\n");

//Console.WriteLine("-------THREAD SAFE SINGLETON WITH MULTIPLE THREADS------");

//Parallel.Invoke(
//    () => MultiThreadTesting.Test2(),
//    () => MultiThreadTesting.Test3()
//);

//Console.WriteLine("-------THREAD SAFE SINGLETON WITH MULTIPLE THREADS------\n");