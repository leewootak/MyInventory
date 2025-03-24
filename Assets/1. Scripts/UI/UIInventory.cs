using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI CurWeight;
    public Button BackBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Awake()
    {
        UIManager.Instance.UIInventory = this;
    }

    private void Start()
    {
        BackBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }
}
