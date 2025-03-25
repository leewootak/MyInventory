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
            new Item("검", 5, LoadIcon("Sword")),
            new Item("갑옷", 5, LoadIcon("Armor")),
            new Item("활", 5, LoadIcon("Bow"))
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
