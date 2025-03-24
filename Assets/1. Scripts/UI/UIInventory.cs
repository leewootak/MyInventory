using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public List<UISlot> uiSlots = new List<UISlot>();

    [Header("UI")]
    public TextMeshProUGUI CurWeight;
    public Button BackBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Start()
    {
        UIManager.Instance.SetInventory(this);
        BackBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        
        for (int i = 0; i < uiSlots.Count; i++)
        {
            Instantiate(uiSlots[i]);
        }
    }
}
