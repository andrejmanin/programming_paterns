namespace flyweight;

public class StoneFactory
{
    private List<StaticStone> _stonesType = new List<StaticStone>();

    public StaticStone getStonesType(string color, Texture texture)
    {
        foreach (var el in _stonesType)
        {
            if (el.getColor() == color && el.getTexture() == texture)
            {
                return el;
            }
        }
        StaticStone stone = new StaticStone(color, texture);
        _stonesType.Add(stone);
        return stone;
    }
}