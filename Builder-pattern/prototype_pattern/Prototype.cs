namespace Builder_pattern.prototype_pattern;

public interface IPrototype<T>
{
    T copy(T obj);
}

public class CopyCar : IPrototype<Car>
{
    public Car copy(Car obj)
    {
        return new Car(obj.getEngine(), obj.getDoor(), obj.getSeat(), obj.getWell());
    }
}