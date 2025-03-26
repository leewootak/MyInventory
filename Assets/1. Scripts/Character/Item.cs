using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StatType
{
    Atk,
    Def,
    Hp,
    Cri
}

public class Item
{
    public string Name { get; private set; }
    public Dictionary<StatType, int> Stats { get; private set; }
    public Sprite Icon { get; private set; }

    public Item(string name, Sprite icon, Dictionary<StatType, int> stats)
    {
        Name = name;
        Stats = stats;
        Icon = icon;
    }

    public int GetStat(StatType statType)
    {
        return Stats != null && Stats.ContainsKey(statType) ? Stats[statType] : 0;
    }
}
