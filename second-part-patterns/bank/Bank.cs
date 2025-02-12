using second_part_patterns.card;

namespace second_part_patterns.bank;

public class Bank : IBank
{
    public Card createCard(string name, CardType cardType)
    {
        Random rnd = new Random();
        long min = 111111111110;
        long max = 999999999999;
        string number;
        Console.WriteLine("Creating a card");
        if (cardType is CardType.Mastercard)
        {
            number = "5168";
        }
        else
        {
            number = "1234"; 
        }
        number += min + (long)(rnd.NextDouble() * (max - min));
        int month = rnd.Next(1, 12);
        int year = rnd.Next(2028, 2035);
        int cvv = rnd.Next(100, 999);
        return new Card(name, number, month, year, cvv);
    }

    public Card updateCard(Card card)
    {
        return card; // Soon
    }
}