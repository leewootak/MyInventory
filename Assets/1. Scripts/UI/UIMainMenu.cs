using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public bool isStatus, isInventory;

    [Header("Obj")]
    public GameObject MainMenuObj;
    public GameObject UIStatus;
    public GameObject UIInventory;

    [Header("UI")]
    public Button StatusBtn;
    public Button InventoryBtn;

    [Header("Reference")]
    public UIManager UIManager;

    private void Awake()
    {
        UIManager.Instance.UIMainMenu = this;
    }

    private void Start()
    {
        StatusBtn.onClick.AddListener(OpenStatus);
        InventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        if (isStatus)
        {
            isStatus = false;
            UIStatus.SetActive(false);
            MainMenuObj.SetActive(true);
        }
        else if (isInventory)
        {
            isInventory = false;
            UIInventory.SetActive(false);
            MainMenuObj.SetActive(true);
        }
    }

    public void OpenStatus()
    {
        isStatus = true;
        MainMenuObj.SetActive(false);
        UIStatus.SetActive(true);
    }

    public void OpenInventory()
    {
        isInventory = true;
        MainMenuObj.SetActive(false);
        UIInventory.SetActive(true);
    }
}
