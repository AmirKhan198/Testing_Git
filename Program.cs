public class A
{
    public A()
    {
        Console.WriteLine("Version V1");
    }
    public Action GetAction()
    {
        Console.WriteLine("Version B2");
        return () => Console.WriteLine("Version V4");
    }
}