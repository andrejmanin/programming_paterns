using second_part_patterns.user;

namespace second_part_patterns.db;

using System.IO;
using System.Text.Json;

public class UserList : IDataList<User>
{
    private readonly string _filePass;

    public string getFilePass() => _filePass;
    
    public UserList(string fileName)
    {
        _filePass = "/home/andrewmanin/RiderProjects/projection_patterns/second-part-patterns/storage/json_files/" + fileName;
    } 
    
    public void createDataList()
    {
        var userList = new UserDataType { users = new List<User> {} };
        File.WriteAllText(_filePass, JsonSerializer.Serialize(userList));
    }

    public void deleteDataList()
    {
        File.Delete(_filePass);
    }

    public void post(User data)
    {
        string json = File.ReadAllText(_filePass);
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(json) ?? new UserDataType();

        if (data.id == 0)
        {
            data.id = (userData.users.Any() ? userData.users.Max(x => x.id) : 0) + 1;
        }
        userData.users.Add(data);
        File.WriteAllText(_filePass, JsonSerializer.Serialize(userData));
    }

    public string get()
    {
        return File.ReadAllText(_filePass);
    }

    public void updateDataById(int id, User data)
    {
        string json = File.ReadAllText(_filePass);
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(json) ?? new UserDataType();
        data.id = id;
        userData.users[id - 1] = data;
        File.WriteAllText(_filePass, JsonSerializer.Serialize(userData));
    }

    public User? getById(int id)
    {
        string json = File.ReadAllText(_filePass);
        UserDataType userData = JsonSerializer.Deserialize<UserDataType>(json) ?? new UserDataType();
        return userData.users.FirstOrDefault(x => x.id == id);
    }
}