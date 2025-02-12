namespace second_part_patterns.db;

interface IDataList<T>
{
    void createDataList();
    void deleteDataList();
    void post(T data);
    string get();
    void updateDataById(int id, T data);
    
    T? getById(int id);
}