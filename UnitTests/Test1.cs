using abstract_factory_patern;
using factory_patern;

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

}