using System.Data.SqlTypes;
using System.Dynamic;

public class Product
{
    private string _name;
    private string _productID;
    private decimal _priceperunit;
    private int _quantity;

    public Product(string name, string productID, decimal priceperunit, int quantity)
    {
        _name = name;
        _productID = productID;
        _priceperunit = priceperunit;
        _quantity = quantity;
    } 

    public string GetName()
    {
        return _name;
    }
     public string GetProductId()
    {
        return _productID;
    }
     public decimal GetPriceperUnit()
    {
        return _priceperunit;
    }
     public int GetQuantity()
    {
        return _quantity;
    } 
    public void SetName(string name)
    {
        _name = name;
    }
     public void SetProductId(string productID)
    {
        _productID = productID;
    }
     public void SetPricePerUnit(decimal priceperunit )
    {
        
        _priceperunit = priceperunit;
    }
     public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _priceperunit * _quantity;
    } 
}