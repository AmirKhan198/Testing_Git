public class A
{
    public A()
    {
        Console.WriteLine("Version V1");
    }
    public Action GetAction()
    {
        return () => Console.WriteLine("Version V4");
    }
}