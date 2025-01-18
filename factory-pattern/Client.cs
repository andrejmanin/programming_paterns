namespace factory_patern;

public class Client
{
    public void start()
    {
        Console.WriteLine("Iphone factory");
        Factory iphoneFactory = new AppleFactory();
        var iphone = iphoneFactory.createPhone();
        var ipad = iphoneFactory.createTablet();
        Console.WriteLine(iphone.description());
        Console.WriteLine(iphone.price());
        Console.WriteLine(iphone.quantity());
        Console.WriteLine(ipad.description());
        Console.WriteLine(ipad.price());
        Console.WriteLine(ipad.quantity());
        Console.WriteLine();
        
        Console.WriteLine("Samsung Factory");
        Factory samsungFactory = new SamsungFactory();
        var samsungPhone = samsungFactory.createPhone();
        var samsungTablet = samsungFactory.createTablet();
        Console.WriteLine(samsungPhone.description());
        Console.WriteLine(samsungPhone.price());
        Console.WriteLine(samsungPhone.quantity());
        Console.WriteLine(samsungTablet.description());
        Console.WriteLine(samsungTablet.price());
        Console.WriteLine(samsungTablet.quantity());
        Console.WriteLine();
    }
}