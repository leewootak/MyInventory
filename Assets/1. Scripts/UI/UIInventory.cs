using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public UISlot slotPrefab; // 슬롯 프리팹
    public Transform slot; // 슬롯들이 배치될 부모 객체
    public List<UISlot> slots = new List<UISlot>(); // 생성된 슬롯 리스트

    [Header("UI")]
    public Button backBtn;                 

    [Header("Reference")]
    [SerializeField] UIMainMenu uiMainMenu;

    private void Start()
    {
        // UIManager에 InventoryUI 등록
        UIManager.Instance.SetInventory(this);

        // 뒤로가기 버튼 이벤트 설정
        backBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);

        // 슬롯 UI 초기화
        InitInventoryUI();

        // 캐릭터의 인벤토리로부터 초기 슬롯 데이터 세팅
        if (GameManager.Instance.character != null)
        {
            UpdateInventory(GameManager.Instance.character.Inventory);
        }
    }

    // 인벤토리 슬롯을 초기화하고 생성
    private void InitInventoryUI()
    {
        // 기존 슬롯 제거
        foreach (Transform child in slot)
        {
            Destroy(child.gameObject);
        }
        slots.Clear();

        // 슬롯 생성 (기본 42개)
        for (int i = 0; i < 42; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slot);
            newSlot.name = ($"slot{i}");
            slots.Add(newSlot);
        }
    }

    // 슬롯에 아이템 데이터 할당
    public void UpdateInventory(List<Item> items)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (i < items.Count)
            {
                slots[i].SetItem(items[i]); // 아이템 설정
            }
            else
            {
                slots[i].RefreshUI(); // 빈 슬롯 처리
            }
        }
    }
}
