namespace Mastering_Design_Patterns_in_Csharp.SOLID.O;

public class Rectangle : IShape
{
    public float Width { get; set; }
    public float Height { get; set; }
    
    public float CalculateArea()
    {
        return Width * Height;
    }
}