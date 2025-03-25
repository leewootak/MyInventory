using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item
{
    public string ItemName { get; private set; }
    public int PlusStat { get; private set; }
    public Sprite Icon { get; private set; }

    public Item(string itemName, int plusStat, Sprite icon) 
    {
        ItemName = itemName;
        PlusStat = plusStat;
        Icon = icon;
    }
}