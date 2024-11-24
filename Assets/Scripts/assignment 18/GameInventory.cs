using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potionInventory = new Inventory();
        potionInventory.AddItem("Healing potion");
        potionInventory.AddItem("Strength potion");

        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        Inventory mainInventory = potionInventory + elixirInventory;
        mainInventory.ShowItems();
    }

}
