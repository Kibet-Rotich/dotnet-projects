using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Security.Principal;

public class Item
{
    public int Id {get;init;}
    public string Name {get; init;}
    public int Quantity{get; private set;}
    public decimal Price {get; set;}

    public Item(int id, string name, int quantity, decimal price)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public void Restock(int amount)
    {
        if(amount> 0)
        {
            Quantity += amount;

        }
    }     
    public bool TryDeduct(int amount)
    {
        if (amount<= 0 || Quantity < amount)
        {
            return false;
        }
        else
        {
            Quantity -= amount;
           
            return true;
        }
    }
}

public class WarehouseInventory
{
    private List<Item> _items = [];
    public void AddItem(Item item)
    {
        _items.Add(item);

    }
    public bool TryFulfillOrder(int itemId, int quantity, out decimal totalCost)
    {
        var item = _items.FirstOrDefault(s => s.Id == itemId);
        if(item == null || !item.TryDeduct(quantity))
        {
            totalCost = 0;
            return false;
        }
        else
        {
            totalCost = quantity * item.Price;
            return true;
        }
    }
}