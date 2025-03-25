using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    private bool isStatus, isInventory;

    [Header("Btn")]
    [SerializeField] Button statusBtn;
    [SerializeField] Button inventoryBtn;
    
    [Header("Reference")]
    [SerializeField] private UIManager UIManager;

    private void Start()
    {
        UIManager.Instance.SetMainMenu(this);
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        if (isStatus)
        {
            isStatus = false;
            UIManager.Instance.UIStatus.gameObject.SetActive(false);
            UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
        }
        else if (isInventory)
        {
            isInventory = false;
            UIManager.Instance.UIInventory.gameObject.SetActive(false);
            UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
        }
    }

    public void OpenStatus()
    {
        isStatus = true;
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        isInventory = true;
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }
}
