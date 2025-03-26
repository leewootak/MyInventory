using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글톤 인스턴스
    public static GameManager Instance;

    // 캐릭터 정보 접근용 프로퍼티
    public Character character { get; private set; }

    // 플레이어 프리팹
    public GameObject player;

    private void Awake()
    {
        // 싱글톤 설정
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
        // 프레임 고정 및 초기 데이터 설정
        Application.targetFrameRate = 60;
        SetData();
    }

    // 초기 데이터 설정
    void SetData()
    {
        // 아이템 리스트 생성
        List<Item> items = new List<Item>
        {
            new Item(
                "검", // 이름
                LoadIcon("Sword"), // 아이콘
                new Dictionary<StatType, int> // 능력치
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
                new Dictionary<StatType, int>
                {
                    { StatType.Atk, 5 },
                    { StatType.Cri, 5 },
                })
        };

        // 플레이어 오브젝트 생성 및 캐릭터 초기화
        GameObject playerObj = Instantiate(player);
        character = playerObj.GetComponent<Character>();

        // 캐릭터 정보 초기화
        character.Init("뉴비", "Lee", 10, 12, 3, "20,000", 35, 40, 100, 25, items);
    }

    // 리소스에서 아이콘 로드
    Sprite LoadIcon(string name)
    {
        var icon = Resources.Load<Sprite>(name);
        return icon;
    }
}
