using Builder_pattern.prototype_pattern;

namespace Builder_pattern;

public class Client
{
    public static void start()
    {
        Console.WriteLine("Builder pattern\n");
        ADirector? director = Director.get_instance(DirType.BmwDir);
        Console.WriteLine("Director");
        
        Car? bmw = director?.buildCar(DirType.BmwDir, 500, "M4", "BMW", 19, "metallic");
        if (bmw != null)
        {
            bmw.info();
            bmw.drive();
            bmw.stop();
            Console.WriteLine();
            
            Console.WriteLine("Prototype:");
            IPrototype<Car> prototype = new CopyCar();
            Console.WriteLine("Copy into audi:");
            ACar audi = prototype.copy(bmw);
            Console.WriteLine();
            
            audi.info();
            audi.drive();
            audi.stop();
            Console.WriteLine();
        }
        
        Car? mercedes = director?.buildCar(DirType.McdDir, 500, "S540", "Mercedes", 20, "metallic");
        mercedes?.info();
        mercedes?.drive();
        mercedes?.stop();
    }
}