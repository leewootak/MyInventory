using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return instance;
        }
    }

    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu 
    {
        get { return uiMainMenu; }
        set { uiMainMenu = value; }
    }

    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus
    {
        get { return uiStatus; }
        set { uiStatus = value; }
    }

    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory 
    {
        get { return uiInventory; }
        set { uiInventory = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
