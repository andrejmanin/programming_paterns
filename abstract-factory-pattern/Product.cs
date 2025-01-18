namespace abstract_factory_patern;

public interface IProgram
{
    public string openProram();
    public string closeProram();
}

public abstract class Program : IProgram
{
    public abstract string openProram();
    public abstract string closeProram();
    
}

public class WindowsProgram : Program
{
    public override string openProram()
    {
        return "Opening windows program";
    }

    public override string closeProram()
    {
        return "Closing windows program";
    }
}

public class MacProgram : Program
{
    public override string openProram()
    {
        return "Opening mac program";
    }

    public override string closeProram()
    {
        return "Closing mac program";
    }
}

public class LinuxProgram : Program
{
    public override string openProram()
    {
        return "Opening linux program";
    }

    public override string closeProram()
    {
        return "Closing linux program";
    }
}