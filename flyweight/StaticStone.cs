namespace flyweight;

public class Texture
{
    private string _textureName;
    public Texture(string textureName) => _textureName = textureName;
    
    public override string ToString() => _textureName;
}

public class StaticStone
{
    private string _color { get; set; }
    private Texture _texture { get; set; }

    public StaticStone(string color, Texture texture)
    {
        _color = color;
        _texture = texture;
    }

    public void draw()
    {
        Console.WriteLine($"Drawing stone...\nColor: {_color}\nTexture: {_texture}");
    }
    
    public string getColor() => _color;
    public Texture getTexture() => _texture;
}