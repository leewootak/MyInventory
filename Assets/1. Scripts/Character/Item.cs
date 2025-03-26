using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 캐릭터의 능력치 종류
public enum StatType
{
    Atk, // 공격력
    Def, // 방어력
    Hp,  // 체력
    Cri  // 치명타
}

// 아이템 클래스 (장비 아이템 정보 포함)
public class Item
{
    public string Name { get; private set; } // 아이템 이름
    public Dictionary<StatType, int> Stats { get; private set; } // 능력치 정보
    public Sprite Icon { get; private set; } // 아이템 이미지

    // 생성자
    public Item(string name, Sprite icon, Dictionary<StatType, int> stats)
    {
        Name = name;
        Stats = stats;
        Icon = icon;
    }

    // 추가 능력치 값을 가져옴 (없으면 0 반환)
    public int GetStat(StatType statType)
    {
        return Stats != null && Stats.ContainsKey(statType) ? Stats[statType] : 0;
    }
}
