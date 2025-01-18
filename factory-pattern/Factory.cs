namespace factory_patern;

public interface IFactory
{
    public IProduct createPhone();
    public IProduct createTablet();
}

public abstract class Factory : IFactory
{
    public abstract IProduct createPhone();
    public abstract IProduct createTablet();
}

public class AppleFactory : Factory
{
    public override IProduct createPhone() => new IPhone();
    public override IProduct createTablet() => new IPad();
}

public class SamsungFactory : Factory
{
    public override IProduct createPhone() => new Samsung();
    public override IProduct createTablet() => new SamsungPad();
}