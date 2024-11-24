using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> items = new List<string>();
    public void AddItem(string item)
    {
        items.Add(item);
    }
    public void ShowItems()
    {
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }

    public static Inventory operator +(Inventory inventory1, Inventory inventory2)
    {
        Inventory newInventory = new Inventory();
        newInventory.items.AddRange(inventory1.items);
        newInventory.items.AddRange(inventory2.items);
        return newInventory;
    }
}
