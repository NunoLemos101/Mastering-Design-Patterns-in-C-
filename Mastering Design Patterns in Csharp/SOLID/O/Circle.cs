namespace Mastering_Design_Patterns_in_Csharp.SOLID.O;

public class Circle : IShape
{
    public float Radius { get; set; }
    
    public float CalculateArea()
    {
        return (float) (Math.PI * Math.Pow(Radius, 2));
    }
}