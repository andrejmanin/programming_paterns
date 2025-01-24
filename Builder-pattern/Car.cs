using Builder_pattern.car_values;

namespace Builder_pattern;

public interface ICar
{
    public void drive();
    public void stop();
    public void info();
}

public abstract class ACar : ICar 
{
    private Engine _engine;
    private Door _door;
    private Seat _seat;
    private Well _well;

    protected ACar(Engine engine, Door door, Seat seat, Well well)
    {
        this._engine = engine;
        this._door = door;
        this._seat = seat;
        this._well = well;
    }

    public void drive()
    {
        Console.WriteLine("Car is driving");
    }

    public void stop()
    {
        Console.WriteLine("Car is stopped");
    }

    public void info()
    {
        Console.WriteLine($"Car info: \nEngine: {_engine.info()};\nDoor: {_door.info()};\nSeat: {_seat.info()};\nWell: {_well.info()}");
    }
    
    public Engine getEngine() => _engine;
    public Door getDoor() => _door;
    public Seat getSeat() => _seat;
    public Well getWell() => _well;
}

public class Car : ACar
{
    public Car(Engine engine, Door door, Seat seat, Well well) : base(engine, door, seat, well)
    {
    }
    
}

