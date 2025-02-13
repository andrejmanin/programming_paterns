﻿using abstract_factory_patern;
using factory_patern;
using flyweight;

namespace UnitTests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void factoryPattern()
    {
        Client client = new Client();
        client.start();
    }

    [TestMethod]
    public void abstractFactoryPattern()
    {
        Application app = new Application();
        app.start();
    }

    [TestMethod]
    public void builderPattern()
    {
        Builder_pattern.Client app = new Builder_pattern.Client();
        Builder_pattern.Client.start();
    }

    [TestMethod]
    public void second_part_pattern()
    {
        second_part_patterns.Client app = new second_part_patterns.Client();
        app.run();
    }

    [TestMethod]
    public void flyweight_pattern()
    {
        Game game = new Game();
        game.start();
    }

}