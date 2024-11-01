using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.LivesInUSA() ? 5.0 : 35.0; 
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (Product product in products)
        {
            packingLabel.AppendLine($"Product Name: {product.Name}, Product ID: {product.ProductId}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}
