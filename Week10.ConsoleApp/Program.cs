
using Week10.ConsoleApp;

Console.WriteLine("Singleton");

ConfigurationService configurationService = ConfigurationService.GetInstance();

ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance().GetValue("ExampleDb");

var example = configurationService.GetValue("ExampleDb");

Console.WriteLine();

























// Console.WriteLine("Static Contructor");

//new MyClass();
//new MyClass();
//class MyClass
//{
//    static MyClass()
//    {
//        Console.WriteLine("Static constructor.");
//    }

//    public MyClass()
//    {
//        Console.WriteLine("Instance Created.");
//    }
//}

