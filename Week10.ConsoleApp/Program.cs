
using Week10.ConsoleApp;
using Week10.Infrastructure.Services;

Console.WriteLine("Singleton");

//ConfigurationService configurationService = new();

ConfigurationService configurationService = ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance().GetValue("");



var connectionString = configurationService.GetValue("ConnectionStrings:ExampleDb");

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

