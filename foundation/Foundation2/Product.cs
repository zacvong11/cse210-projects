public class Product
{
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string Name => name;
    public string ProductId => productId;
    public double PricePerUnit => pricePerUnit;
    public int Quantity => quantity;

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }
}
