namespace abstract_factory_patern
{
    public class Application
    {
        public void start()
        {
            Console.WriteLine("Abstract Factory Patern");
            Factory windFactory = new WindowsFactory();
            IProgram windProgram = windFactory.createApp();
            Console.WriteLine(windProgram.openProram());
            Console.WriteLine(windProgram.closeProram());
            Console.WriteLine();
            
            Console.WriteLine("MacProgram");
            Factory macFactory = new MacFactory();
            IProgram macProgram = macFactory.createApp();
            Console.WriteLine(macProgram.openProram());
            Console.WriteLine(macProgram.closeProram());
            Console.WriteLine();
            
            Console.WriteLine("LinuxProgram");
            Factory linuxFactory = new LinuxFactory();
            IProgram linuxProgram = linuxFactory.createApp();
            Console.WriteLine(linuxProgram.openProram());
            Console.WriteLine(linuxProgram.closeProram());
            Console.WriteLine();
        }
    }
}