using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusBtn;
    public Button InventoryBtn;

    public UIManager uiManager;

    void OpenMainMenu()
    {
        uiManager.ChangeMenu(0);
    }

    void OpenStatus()
    {
        uiManager.ChangeMenu(0);        
    }

    void OpenInventory()
    {
        uiManager.ChangeMenu(1);
    }
}
