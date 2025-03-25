using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public UISlot slotPrefab;
    public Transform slot;
    public List<UISlot> slots = new List<UISlot>();

    [Header("UI")]
    public TextMeshProUGUI curWeight;
    public Button backBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu uiMainMenu;

    private void Start()
    {
        UIManager.Instance.SetInventory(this);
        backBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);

        InitInventoryUI();

        if (GameManager.Instance.character != null)
        {
            UpdateInventory(GameManager.Instance.character.Inventory);
        }
    }

    private void InitInventoryUI()
    {
        // 슬롯 초기화
        foreach (Transform child in slot)
        {
            Destroy(child.gameObject);
        }
        slots.Clear();

        // 슬롯 생성
        for (int i = 0; i < 42; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slot);
            newSlot.name = ($"slot{i}");
            slots.Add(newSlot);
        }
    }

    public void UpdateInventory(List<Item> items)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (i < items.Count)
            {
                slots[i].SetItem(items[i]);
            }
            else
            {
                slots[i].RefreshUI();
            }
        }
    }
}
