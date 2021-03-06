﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Faction Faction { get; set; }
    public Territory CurrentTerritory { get; set; }
    public bool HasGlasses { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }
    public int NumPlayer { get; set; }
    public Dictionary<Item, int> Inventory { get; set; }

    public int NumberOfItem(Item item)
    {
        var numberItem=0;
        if (Inventory.TryGetValue(item,out numberItem))
        {
            return numberItem;
        }
        return 0;
    }
    public Player ()
    {
        HasGlasses = false;
        Level = 1;
        Gold = 0;
        Inventory = new Dictionary<Item, int>();
    }

}
