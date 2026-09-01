/*
using OmniVet.Core.Shared;

namespace OmniVet.Core.Inventory;

public class Product : IEntity<int>
{
    public int Id {get;}

    public string ProductName 
    {
        get;
        private set => field = !string.IsNullOrWhiteSpace(value) switch
        {
            true => throw new Exception("El nombre del producto es un campo obligatorio"),
            _ => field = value.Trim()          
        };    
    }    

    public Product(string productname)
    {
        ProductName = productname;
    }
}
*/