namespace flyweight;

public class Game
{
    public void start()
    {
        StoneFactory factory = new StoneFactory();
        StaticStone stoneType = factory.getStonesType("grey", new Texture("Stone"));
        DynamicStone stone = new DynamicStone(1123, 44134, 643, stoneType);
        stone.drawStone();
    }
}