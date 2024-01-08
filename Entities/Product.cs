namespace store.Entities;
public class Product
{
    public Product(int id, string name, int qty, string details)
    {
        this.id = id;
        this.name = name;
        this.Quantity = qty;
        this.details = details;
    }
    public int id { get; set; }
    public string name { get; set; }
    public int Quantity { get; set; }
    public string details { get; set; }
    public override string ToString()
    {
        return id + " name: " + name + " quantity:" + " details: " + details;
    }
}