using System;

public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("все работает");
    }
}

class Program
{
    static void Main()
    {
        Singleton singleton = Singleton.Instance;
        singleton.DoSomething(); 
    }
}