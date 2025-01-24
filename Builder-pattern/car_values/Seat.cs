namespace Builder_pattern.car_values;


public interface ISeat
{
    string info();
}

public class Seat : ISeat
{
    public string info()
    {
        return "seat info";
    }
}