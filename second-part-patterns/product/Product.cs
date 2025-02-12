namespace second_part_patterns;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public float price { get; set; }
    public int count { get; set; }
    public string? description { get; set; }

    public Product() {}

    public Product(string name, float price, int count)
    {
        this.name = name;
        this.price = price;
        this.count = count;
    }

    public Product(string name, float price, int count, string description) : this(name, price, count)
    {
        this.description = description;
    }
}
