// See https://aka.ms/new-console-template for more information

using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory;
using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

Console.WriteLine("Hello, World!");

var factory = ShapeFactoryProvider.GetFactory<Circle>();

var shape = factory.Create();
var circle = factory.CreateAsObject();