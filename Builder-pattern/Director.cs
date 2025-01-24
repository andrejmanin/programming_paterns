using System.Collections.Immutable;

namespace Builder_pattern;

public enum DirType
{
    BmwDir,
    McdDir,
    AudDir
}

internal interface IDirector
{
    Car? buildCar(DirType type, int hp, string name, string company, int radius, string material);
}

public abstract class ADirector : IDirector
{
    private Builder _carBuilder;
    
    protected ADirector(Builder carBuilder)
    {
        _carBuilder = carBuilder;
    }

    public abstract Car? buildCar(DirType type, int hp, string name, string company, int radius, string material);

    protected Builder getCarBuilder() => _carBuilder;
}

public class Director : ADirector
{
    private static Director? _bmwDirector;
    private static Director? _mercedesDirector;
    private static Director? _audiDirector;

    private Director(Builder builder) : base(builder)
    {
    }

    public static Director? get_instance(DirType type)
    {
        switch (type)
        {
            case DirType.BmwDir:
            {
                if (_bmwDirector == null)
                {
                    _bmwDirector = new Director(new BmwBuilder());
                }
                return _bmwDirector;
            }
            case DirType.McdDir:
            {
                if (_mercedesDirector == null)
                {
                    _mercedesDirector = new Director(new MercedesBuilder());
                }
                return _mercedesDirector;
            }
            case DirType.AudDir:
            {
                if (_audiDirector == null)
                {
                    _audiDirector = new Director(new AudiBuilder());
                }
                return _audiDirector;
            }
            default:
                return null;
        }
    }
    
    public override Car? buildCar(DirType type, int hp, string name, string company, int radius, string material)
    {
        switch (type)
        {
            case DirType.BmwDir:
            {
                return new Car(getCarBuilder().BuildEngine(hp, name, company), getCarBuilder().BuildDoors(), getCarBuilder().BuildSeats(), getCarBuilder().BuildWells(radius, name, material));
            }
            case DirType.McdDir:
            { 
                return new Car(getCarBuilder().BuildEngine(hp, name, company), getCarBuilder().BuildDoors(), getCarBuilder().BuildSeats(), getCarBuilder().BuildWells(radius, name, material));
            }
            case DirType.AudDir:
            {
                return new Car(getCarBuilder().BuildEngine(hp, name, company), getCarBuilder().BuildDoors(), getCarBuilder().BuildSeats(), getCarBuilder().BuildWells(radius, name, material));
            }
            default:
                return null;
        }
    }
}

