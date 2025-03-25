using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Character : MonoBehaviour
{
    public string Title { get; private set; } = "뉴비";
    public string Name { get; private set; } = "Lee";
    public int Level { get; private set; } = 10;
    public int MaxExp { get; private set; } = 12;
    public int CurExp { get; private set; } = 3;
    public string Gold { get; private set; } = "20,000";
    public int Atk { get; private set; } = 35;
    public int Def { get; private set; } = 40;
    public int Hp { get; private set; } = 10;
    public int Cri { get; private set; } = 25;
    public Image CurExpBar;

    public List<Item> Inventory { get; private set; }

    private List<Item> equippedItems = new List<Item>();

    [SerializeField] UISlot uiSlot;

    public void Init(string title, string name, int level, int maxExp, int curExp, string gold, int atk, int def, int hp, int cri, List<Item> inventory)
    {
        Title = title;
        Name = name;
        Level = level;
        MaxExp = maxExp;
        CurExp = curExp;
        Gold = gold;
        Atk = atk;
        Def = def;
        Hp = hp;
        Cri = cri;
        Inventory = new List<Item>(inventory);

        UIManager.Instance.AlwaysUI.SetCharacterInfo(this);
        UIManager.Instance.UIStatus.SetStatus(this);
        CurExpBar.fillAmount = (float)CurExp / MaxExp;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public bool IsEquipped(Item item)
    {
        return equippedItems.Contains(item);
    }

    public void ToggleEquip(Item item)
    {
        if (equippedItems.Contains(item))
        {
            equippedItems.Remove(item);
        }
        else
        {
            equippedItems.Add(item);
        }
    }
}
