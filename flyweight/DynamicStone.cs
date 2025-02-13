namespace flyweight;

public class DynamicStone
{
    private int _x { get; set; }
    private int _y { get; set; }
    private int _z { get; set; }
    private StaticStone _stone { get; set; }
    
    public DynamicStone(int x, int y, int z, StaticStone stone)
    {
        _x = x;
        _y = y;
        _z = z;
        _stone = stone;
    }

    public void drawStone() => _stone.draw();
}