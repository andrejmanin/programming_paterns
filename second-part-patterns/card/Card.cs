using System.Text.Json.Serialization;
using second_part_patterns.bank;

namespace second_part_patterns.card;



public class Card : ICard
{
    public string name { get; private set; }
    public string number { get; private set; }
    public int month {get; private set; }
    public int year {get; private set; }
    public int cvv { private get;  set; }
    // public readonly Bank _bank; Soon
    public CardType type { get; }
    public float balance {get; set;}

    [JsonConstructor]
    public Card(string name, string number, int month, int year, int cvv /*Bank*/)
    {
        this.name = name;
        this.number = number;
        
        string type = this.number.Substring(0, 4);
        if(type == "5168")
            this.type = CardType.Mastercard;
        else
            this.type = CardType.Visa;
        
        this.month = month;
        this.year = year;
        this.cvv = cvv;
        balance = 0;
        /*_bank = bank;*/
    }
    
    public bool payment(float price, int count)
    {
        if (price < 0)
        {
            return false;
        }
        balance -= price * count;
        return true;
    }

    public bool updateBalance(float count)
    {
        if (count < 0)
        {
            return false;
        }
        balance += count;
        return true;
    }
    
    public string getCardName() => name;
    public string getCardNumber() => number;
    public CardType getCardType() => type; 
    
    /* 
     * Add to bank notify system Soon
    */
    
    public override string ToString() => $"{name}: {number} \n({month}-{year})\nCVV: {cvv}";
}