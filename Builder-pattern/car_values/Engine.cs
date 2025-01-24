namespace Builder_pattern
{
    namespace car_values
    {
        public interface IEngine
        {
            void run();
            void stop();
            string info();
        }
        
        public class Engine : IEngine
        {
            private int _hp;
            private readonly string _name;
            private readonly string _company;
        
            public Engine(int hp, string name, string company)
            {
                this._hp = hp;
                this._name = name;
                this._company = company;
            }
        
            public void run()
            {
                Console.WriteLine($"{_name} is running...");
            }
        
            public void stop()
            {
                Console.WriteLine($"{_name} is stopped...");
            }
        
            public string info()
            {
                return $"{_company} {_name} has {_hp} HP";
            }
            
            public int getHp() => _hp;
        
            public void setHp(int hp)
            {
                if (hp <= 0)
                {
                    throw new ArgumentException("hp is zero or negative");
                }
                _hp = hp;
            }
            
            public string getName() => _name;
            public string getCompany() => _company;
        }
    }
}
