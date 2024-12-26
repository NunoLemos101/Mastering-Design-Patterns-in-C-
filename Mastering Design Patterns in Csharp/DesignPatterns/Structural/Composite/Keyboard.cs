namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Composite;

public class Keyboard : IItem
{
    private readonly float _price = 40.00f;

    public float GetPrice()
    {
        return _price;
    }
}