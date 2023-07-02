class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name
    {
        get { return name; }
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public decimal GetShippingCost()
    {
        return address.IsInUSA() ? 5m : 35m;
    }

    public string GetAddressString()
    {
        return address.ToString();
    }
}
