namespace abstract_factory_patern;

public interface IFactory
{
    public IProgram createApp();
}

public abstract class Factory : IFactory
{
    public abstract IProgram createApp();
}

public class WindowsFactory : Factory
{
    public override IProgram createApp() => new WindowsProgram();
}

public class LinuxFactory : Factory
{
    public override IProgram createApp() => new LinuxProgram();
}

public class MacFactory : Factory
{
    public override IProgram createApp() => new MacProgram();
}