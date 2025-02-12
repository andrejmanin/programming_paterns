namespace second_part_patterns.card;

public interface ICard
{
    bool payment(float price, int count);
    bool updateBalance(float count);
    string getCardName();
    string getCardNumber();
    CardType getCardType();
    
    string ToString();
}