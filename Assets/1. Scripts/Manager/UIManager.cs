using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameObject uiMainMenu;
    public UIMainMenu UIMainMenu { get; private set; }

    private GameObject uiStatus;
    public UIStatus UIStatus { get; private set; }

    private GameObject uiInventory;
    public UIInventory UIInventory { get; private set; }

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
            UIManager.Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void ChangeMenu(int amount)
    {
        switch (amount)
        {
            case 0:
                uiMainMenu.SetActive(false);
                uiStatus.SetActive(true);
                break;
            case 1:
                uiMainMenu.SetActive(false);
                uiInventory.SetActive(true);
                break;
        }

    }
}
