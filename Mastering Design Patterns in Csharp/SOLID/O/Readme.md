# Open/Closed principle

The open/closed principle states that a class should be open for extension but closed for modification. This means that a class should be able to be extended without modifying the class itself. This is achieved by using inheritance, interfaces and composition.

In this example we have an ``IShape`` interface and we can create new shapes by implementing this interface. We can then create a ``Drawing`` class that can draw any shape that implements the ``IShape`` interface.

One bad way of implementing this functionality would be to use an enum to represent the shape type and then use a switch statement to calculate the area of each shape.

```csharp
public enum ShapeType
{
    Circle,
    Rectangle
}

public class Shape
{
    // This method should only calculate area
    // If we add a new shape, it should not change
    // And in this example we would need to change it
    // if we now wanted to add a new shape
    public double CalculateArea(ShapeType shapeType, double radius, double width, double height)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                return radius * radius * Math.PI;
            case ShapeType.Rectangle:
                return width * height;
            default:
                throw new Exception("Shape type not supported");
        }
    }
}
```

