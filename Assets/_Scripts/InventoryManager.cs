using UnityEngine;
using System.Collections.Generic;
using static UnityEditor.Progress;

public class InventoryManager : MonoBehaviour
{
    private Dictionary<string, Item> inventory = new Dictionary<string, Item>();

    void Start()
    {
        // Add items to the inventory
        AddItem("Health Potion", 3);
        AddItem("Mana Potion", 2);
        AddItem("Gold", 100);

        // Remove an item from the inventory
        RemoveItem("Gold", 50);

        // Display the inventory
        PrintInventory();
    }

    void AddItem(string itemName, int quantity)
    {
        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName].quantity += quantity;
        }
        else
        {
            inventory.Add(itemName, new Item(itemName, quantity));
        }
    }

    void RemoveItem(string itemName, int quantity)
    {
        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName].quantity -= quantity;
            if (inventory[itemName].quantity <= 0)
            {
                inventory.Remove(itemName);
            }
        }
    }

    void PrintInventory()
    {
        foreach (var item in inventory.Values)
        {
            Debug.Log(item.name + ": " + item.quantity);
        }
    }
}
public class Item
{
    public string name;
    public int quantity;

    public Item(string name, int quantity)
    {
        this.name = name;
        this.quantity = quantity;
    }
}
