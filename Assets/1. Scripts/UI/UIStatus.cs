using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI curAtk;
    public TextMeshProUGUI curDef;
    public TextMeshProUGUI curHp;
    public TextMeshProUGUI curCri;
    public Button BackBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Awake()
    {
        UIManager.Instance.UIStatus = this;
    }

    private void Start()
    {
        BackBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }
}
