class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in products)
        {
            total += product.Price * product.Quantity;
        }

        total += customer.GetShippingCost();
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += "Name: " + product.Name + ", Product ID: " + product.ProductId + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return "Name: " + customer.Name + "\nAddress: " + customer.GetAddressString();
    }
}