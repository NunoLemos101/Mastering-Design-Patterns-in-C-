namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Composite;

public class Box : IItem
{
    private readonly List<IItem> _items = new List<IItem>();

    public void Add(IItem item)
    {
        _items.Add(item);
    }

    public float GetPrice()
    {
        float total = 0f;
        foreach (var item in _items)
        {
            total += item.GetPrice();
        }
        return total;
    }
}