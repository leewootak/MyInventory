using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Character character { get; private set; }

    public GameObject player;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetData();
    }

    void SetData()
    {
        List<Item> items = new List<Item>
        {
            new Item(
                "검",
                LoadIcon("Sword"),
                new Dictionary<StatType, int>
                {
                    { StatType.Atk, 10 }
                }),
            new Item(
                "갑옷",
                LoadIcon("Armor"),
                new Dictionary<StatType, int>
                {
                    { StatType.Def, 10 },
                    { StatType.Hp, 50 }
                }),
            new Item(
                "활", 
                LoadIcon("Bow"),
                new Dictionary < StatType, int >
                {
                    { StatType.Atk, 5 },
                    { StatType.Cri, 5 },
                })
        };

        GameObject playerObj = Instantiate(player);
        character = playerObj.GetComponent<Character>();

        character.Init("뉴비", "Lee", 10, 12, 3, "20,000", 35, 40, 100, 25, items);
    }

    Sprite LoadIcon(string name)
    {
        var icon = Resources.Load<Sprite>(name);
        return icon;
    }
}
