// See https://aka.ms/new-console-template for more information
using HelloWorldApplication;

MyClass myClass = new MyClass(10,23);
MyClass myClass1 = new MyClass(myClass);
myClass.HelloWorld();
Console.ReadKey();

Console.WriteLine("rollno{0}", myClass.RollNo);

