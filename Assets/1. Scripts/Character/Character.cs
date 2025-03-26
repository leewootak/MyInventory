using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    // 캐릭터 기본 정보
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

    public Image CurExpBar; // 경험치 바 UI

    public List<Item> Inventory { get; private set; } // 인벤토리 아이템 리스트

    private List<Item> equippedItems = new List<Item>(); // 장착 중인 아이템 리스트

    [SerializeField] UISlot uiSlot; // UI 슬롯 참조 (현재 미사용)

    // 캐릭터 초기화 함수
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

        // UI 업데이트
        UIManager.Instance.AlwaysUI.SetCharacterInfo(this);
        UIManager.Instance.UIStatus.SetStatus(this);
        CurExpBar.fillAmount = (float)CurExp / MaxExp;
    }

    // 아이템 추가 함수
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    // 아이템이 장착 중인지 확인
    public bool IsEquipped(Item item)
    {
        return equippedItems.Contains(item);
    }

    // 아이템 장착/해제 토글
    public void ToggleEquip(Item item)
    {
        if (equippedItems.Contains(item))
        {
            equippedItems.Remove(item); // 장착 해제
        }
        else
        {
            equippedItems.Add(item); // 장착
        }

        // 상태 UI 갱신
        UIManager.Instance.UIStatus.SetStatus(this);
    }

    // 아이템 장착을 통해 얻는 추가 스탯
    public int GetPlusStat(StatType statType)
    {
        int plus = 0;
        foreach (var item in equippedItems)
        {
            plus += item.GetStat(statType);
        }
        return plus;
    }
}
