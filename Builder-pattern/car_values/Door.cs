namespace Builder_pattern.car_values
{
    public interface IDoor
    {
        string info();
    }
    public class Door : IDoor
    {
        public string info()
        {
            return "door info";
        }
    }
}
