namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Decorator;

public class EncryptionDecorator : DataDecorator
{
    public EncryptionDecorator(IData data) : base(data) { }

    public override void Save(string data)
    {
        System.Console.WriteLine("Encryping data");
        var encrypted = Encrypt(data);
        base._data.Save(encrypted);
    }
    private string Encrypt(string data)
    {
        return "$dc&^*()';,,£@%%*(~)`"; // pretend to encrypt data
    }
}