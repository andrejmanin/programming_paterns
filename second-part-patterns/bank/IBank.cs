using second_part_patterns.card;

namespace second_part_patterns.bank;

public interface IBank
{
    Card createCard(string name, CardType cardType);
    Card updateCard(Card card);
    
}