namespace factory_patern;


public interface IProduct
{
    string description();
    int price();
    int quantity();
}

public abstract class Product : IProduct
{
    public abstract string description();

    public abstract int price();

    public abstract int quantity();
    
}

public class IPhone : Product
{
    public override string description()
    {
        return "Iphone phone";
    }

    public override int price()
    {
        return 1200;
    }

    public override int quantity()
    {
        return 10;
    }
}

public class Samsung : Product
{
    public override string description()
    {
        return "Samsung phone";
    }

    public override int price()
    {
        return 1000;
    }

    public override int quantity()
    {
        return 20;
    }
}

public class IPad : Product
{
    public override string description()
    {
        return "IPad tablet";
    }

    public override int price()
    {
        return 1400;
    }

    public override int quantity()
    {
        return 30;
    }
}

public class SamsungPad : Product
{
    public override string description()
    {
        return "Samsung Pad tablet";
    }

    public override int price()
    {
        return 1250;
    }

    public override int quantity()
    {
        return 25;
    }
}

