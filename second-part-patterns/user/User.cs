using second_part_patterns.card;

namespace second_part_patterns.user;


public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public float balance { get; set; }
    public string email { get; set; }
    public Card? card { get; set; } 

    public User() {}
    public User(string name, float balance, string email)
    {
        this.name = name;
        this.balance = balance;
        this.email = email;
    }

    public User(int id, string name, float balance, string email) : this(name, balance, email)
    {
        this.id = id;
    }

    public User(int id, string name, float balance, string email, Card? card) : this(id, name, balance, email)
    {
        this.card = card;
    }
    
    public void updateBalance(float amount)
    {
        balance += amount;
    } 
    
    public override string ToString() => $"User name: {name}, \nBalance: {balance}, \nEmail: {email}";

}