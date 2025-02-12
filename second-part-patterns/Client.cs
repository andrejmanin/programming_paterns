using second_part_patterns.bank;
using second_part_patterns.card;
using second_part_patterns.db;
using second_part_patterns.user;

namespace second_part_patterns;

using System.Text.Json;

public class Client
{
    public void prodTest()
    {
        db.ProductList list = new db.ProductList("/data.json");
        list.createDataList();
        
        list.post(new Product("Pad 6", 15000, 1, "Coolest tablet"));
        
        list.post(new Product("Iphone 14 Pro", 35000, 1, "Coolest phone"));
        
        list.post(new Product("Laptop", 30000, 1, "Coolest laptop"));
        Console.WriteLine(list.get() + '\n');
        
        Product? prod = list.getById(2);
        Console.WriteLine(prod?.description);
    }

    void userTest()
    {
        EncryptionList encList = new EncryptionList();
        
        encList.post(new User("Andrij", 100.50F, "andrejmanin44@gmail.com"));
        encList.post(new User("Max", 150.99F, "max@gmail.com"));
        encList.post(new User("John", 50.01F, "john@gmail.com"));
        
        User user = new User("Bob", 500.00F, "bob@gmail.com");
        Bank bank = new Bank();
        user.card = bank.createCard(user.name, CardType.Mastercard);
        encList.post(user);
        
        Console.WriteLine(encList.get() + '\n');
        Console.WriteLine(encList.getUserById(4).name);
        
        user = new User("Andrew", 511.00F, "john@gmail.com");
        user.card = bank.createCard(user.name, CardType.Mastercard);
        encList.updateDataById(3, user);
        Console.WriteLine(encList.getUserById(3).name);
    }
    
    public void run()
    {
        // prodTest();
        userTest();
        
        /*EncryptionList encList = new EncryptionList();
        
        encList.post(new User("Andrij", 100.50F, "andrejmanin44@gmail.com"));
        encList.post(new User("Max", 150.99F, "max@gmail.com"));
        encList.post(new User("John", 50.01F, "john@gmail.com"));

        User user = encList.getUserById(1);
        Console.WriteLine(user);
        */

        /*Bank bank = new Bank();
        User user  = new User("Andrej", 100.50F, "andrejmanin44@gmail.com");
        user.card = bank.createCard(user.name, CardType.Mastercard);

        Console.WriteLine($"{user.card}");*/

        /*User user = new User("Bob", 500.00F, "bob@gmail.com");
        Bank bank = new Bank();
        user.card = bank.createCard(user.name, CardType.Mastercard);
        user.card.updateBalance(50.00F);
        Console.WriteLine(JsonSerializer.Serialize(user.card));*/
    }
}