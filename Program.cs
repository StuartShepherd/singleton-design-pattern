using SingletonDesignPattern;

Console.WriteLine("Singleton Design Pattern");
Console.WriteLine("Singleton is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.");
Console.WriteLine();

var singleton1 = Singleton.GetInstance();
var singleton2 = Singleton.GetInstance();

if (singleton1 == singleton2)
    Console.WriteLine("Both variables contain the same instance.");

if (singleton1 != singleton2)
    Console.WriteLine("Variables contain different instances.");
