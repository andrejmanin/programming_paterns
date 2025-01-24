namespace Builder_pattern.car_values;

public interface IWell
{
    string info();
    float getRadius();
    string getName();
    string getMaterial();
}

public class Well : IWell
{
    private readonly float _radius;
    private readonly string _name;
    private readonly string _material;

    public Well(float radius, string name, string material)
    {
        this._radius = radius;
        this._name = name;
        this._material = material;
    }
    
    public string info()
    {
        return $"\n\tName:{this._name}; \n\tRadius: {this._radius}; \n\tMaterial: {this._material}";
    }
    
    public float getRadius() => this._radius;
    public string getName() => this._name;
    public string getMaterial() => this._material;
}