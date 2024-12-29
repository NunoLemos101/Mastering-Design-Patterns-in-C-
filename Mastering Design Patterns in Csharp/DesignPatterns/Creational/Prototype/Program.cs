namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Prototype;

public class Program
{
    public static void Main()
    {
        Rectangle rectanglePrototype = new Rectangle("Blue") { X = 10, Y = 20, Width = 30, Height = 40 };
        Circle circlePrototype = new Circle("Red") { X = 50, Y = 60, Radius = 15 };

        Rectangle rectangle1 = (Rectangle)rectanglePrototype.Clone();
        rectangle1.X = 100; // Modify cloned object without affecting the prototype
        rectangle1.Draw();

        Rectangle rectangle2 = (Rectangle)rectanglePrototype.DeepClone();
        rectangle2.Color = "Green";
        rectangle2.Draw();

        Circle circle1 = (Circle)circlePrototype.Clone();
        circle1.Y = 100;
        circle1.Draw();

        Circle circle2 = (Circle)circlePrototype.DeepClone();
        circle2.Radius = 30;
        circle2.Draw();
        
        // Demonstrate that prototypes are unchanged
        rectanglePrototype.Draw();
        circlePrototype.Draw();
    }
}