namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Composite;

public class Mouse : IItem
{
    private readonly float _price = 18.00f;

    public float GetPrice()
    {
        return _price;
    }
}