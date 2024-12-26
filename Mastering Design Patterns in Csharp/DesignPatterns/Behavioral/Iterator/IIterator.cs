namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Iterator;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}