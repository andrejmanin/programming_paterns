using second_part_patterns.user;

namespace second_part_patterns.db;

using System.IO;
using System.Text.Json;

public class ProductList : IDataList<Product>
{
    private readonly string _filePass;

    public ProductList(string filename = "dataList.json")
    {
        _filePass = "/home/andrewmanin/RiderProjects/projection_patterns/second-part-patterns/storage/json_files/" + filename;
    } 

    public void createDataList()
    {
        var newProductList = new second_part_patterns.ProductDataType { products = new List<Product> {} };
        File.WriteAllText(_filePass, JsonSerializer.Serialize(newProductList));
    }

    public void deleteDataList() => File.Delete(_filePass);
    public string get()
    {
        using StreamReader sr = new StreamReader(_filePass);
        string jsonData = sr.ReadToEnd();
        sr.Close();
        return jsonData;
    }

    public void updateDataById(int id, Product data)
    {
        string json = File.ReadAllText(_filePass);
        ProductDataType productData = JsonSerializer.Deserialize<ProductDataType>(json) ?? new ProductDataType();
        
        productData.products[id] = data;
        File.WriteAllText(_filePass, JsonSerializer.Serialize(productData));
    }

    public void post(Product data)
    {
        string jsonData = File.ReadAllText(_filePass);
        ProductDataType productsDataType = JsonSerializer.Deserialize<ProductDataType>(jsonData) ?? new ProductDataType();
        
        if (data.id == 0)
        {
            data.id = (productsDataType.products.Any() ? productsDataType.products.Max(p => p.id) : 0) + 1;
        }

        productsDataType.products.Add(data); 
        File.WriteAllText(_filePass, JsonSerializer.Serialize(productsDataType));
    }

    public Product? getById(int id)
    {
        string jsonData = File.ReadAllText(_filePass);
        second_part_patterns.ProductDataType productsDataType = JsonSerializer.Deserialize<second_part_patterns.ProductDataType>(jsonData) ?? new second_part_patterns.ProductDataType();
        
        return productsDataType.products.FirstOrDefault(x => x.id == id);
        
    }
}