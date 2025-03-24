using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public bool isStatus, isInventory;

    [Header("UI")]
    [SerializeField] Button StatusBtn;
    [SerializeField] Button InventoryBtn;

    [Header("Reference")]
    [SerializeField] private UIManager UIManager;

    private void Start()
    {
        Debug.Log("UIManager.Instance is: " + UIManager.Instance);
        UIManager.Instance.SetMainMenu(this);
        StatusBtn.onClick.AddListener(OpenStatus);
        InventoryBtn.onClick.AddListener(OpenInventory);
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
