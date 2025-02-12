using System.Text.Json;

namespace second_part_patterns.db;

using user;

public class EncryptionList
{
    private readonly int _displacement = 2;
    private UserList _userList { get; set; }

    private string encryptStr(string data)
    {
        string encryptStr = "";
        foreach (char el in data)
        {
            char newEl = (char)(el + _displacement);
            encryptStr += newEl;
        }
        return encryptStr;
    }

    private int encryptInt(int data)
    {
        string encryptStr = "", dataString = data.ToString();
        foreach (char el in dataString)
        {
            char newEl = (char)(el + _displacement);
            encryptStr += newEl;
        }
        return Convert.ToInt32(encryptStr);
    }

    private string decryptStr(string data)
    {
        string decryptStr = ""; 
        foreach (char el in data)
        {
            char newEl = (char)(el - _displacement);
            decryptStr += newEl;
        }
        return decryptStr;
    }

    private int decryptInt(int data)
    {
        string decryptStr = "";
        string dataString = data.ToString();
        foreach (char el in dataString)
        {
            char newEl = (char)(el - _displacement);
            decryptStr += newEl;
        }
        return Convert.ToInt32(decryptStr);
    }

    private User encryptUser(User data)
    {
        if(data.card == null) 
            return new User(data.id, encryptStr(data.name), data.balance, encryptStr(data.email));
        return new User(data.id, encryptStr(data.name), data.balance, encryptStr(data.email), data.card);
    }

    private User decryptUser(User? data)
    {
        if (data == null) return new User();
        if(data.card == null)
            return new User(data.id, decryptStr(data.name), data.balance, decryptStr(data.email));
        return new User(data.id, decryptStr(data.name), data.balance, decryptStr(data.email), data.card);
    }
    
    public EncryptionList(string fileName = "users.json")
    {
        _userList = new UserList(fileName);
        _userList.createDataList();
    }
    
    public void deleteList() => _userList.deleteDataList();

    public void post(User data)
    {
        _userList.post(encryptUser(data));
    }

    public string get()
    {
        string jsonData = File.ReadAllText(_userList.getFilePass());
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(jsonData) ?? new UserDataType();

        foreach (var user in userData.users)
        {
            user.name = decryptStr(user.name);
            user.email = decryptStr(user.email);
        }
        return JsonSerializer.Serialize(userData);
    }

    public void updateDataById(int id, User data)
    {
        string jsonData = File.ReadAllText(_userList.getFilePass());
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(jsonData) ?? new UserDataType();
        User decUser = decryptUser(userData.users[id]);
        decUser.name = data.name;
        decUser.email = data.email;
        decUser.balance = data.balance;
        userData.users[id] = encryptUser(decUser);
        File.WriteAllText(_userList.getFilePass(), JsonSerializer.Serialize(userData));
    }

    public User getUserById(int id)
    {
        string json = File.ReadAllText(_userList.getFilePass());
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(json) ?? new UserDataType();
        User user = decryptUser(userData.users.FirstOrDefault(u => u.id == id));
        return user;
    }
}