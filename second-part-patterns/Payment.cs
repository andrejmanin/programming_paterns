using second_part_patterns.db;
using second_part_patterns.user;

namespace second_part_patterns;

public interface IPayment
{
    float getPaymentAmount(int productId);
    bool payment(int userId, int productId);
    float paymentError();
    float updateBalance();
}

public abstract class Payment : IPayment
{
    public virtual float getPaymentAmount(int productId)
    {
        return 0F; // Soon
    }
    public abstract bool payment(int userId, int productId);
    public abstract float paymentError();
    public abstract float updateBalance();
}

public class PrivateBankPayment : Payment
{
    private readonly ProductList _productList;
    private readonly UserList _userList;
    
    
    public PrivateBankPayment()
    {
        _productList = new ProductList("private_bank_products.json");
        _userList = new UserList("private_bank_users.json");
        
        _productList.createDataList();
        _userList.createDataList();
    }
    
    public override bool payment(int userId, int productId)
    {
        if(_productList.getById(productId) != null)
        {
            float price = _productList.getById(productId)!.price;
            User? user = _userList.getById(userId);
            if (user.balance < price)
            {
                return false;
            }

            user.balance -= price;
            _userList.updateDataById(userId, user);
            return true;
        }
        return false;
    }

    public override float paymentError()
    {
        return 0F; // Soon
    }

    public override float updateBalance()
    {
        return 0F; // Soon
    }
}