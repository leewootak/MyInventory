using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public UISlot slotPrefab;
    public Transform slot;
    public List<UISlot> slotList = new List<UISlot>();

    [Header("UI")]
    public TextMeshProUGUI curWeight;
    public Button backBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu uiMainMenu;

    private void Start()
    {
        UIManager.Instance.SetInventory(this);
        backBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);

        SlotSetting();
    }

    private void SlotSetting()
    {
        // ½½·Ô ÃÊ±âÈ­
        foreach (Transform child in slot)
        {
            Destroy(child.gameObject);
        }
        slotList.Clear();

        // ½½·Ô »ý¼º
        for (int i = 0; i < 42; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slot);
            newSlot.name = ($"slot{i}");
            slotList.Add(newSlot);
        }
    }
}
