using UnityEngine;

public class UIManager : MonoBehaviour
{
    // �̱��� �ν��Ͻ�
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    // ���� �޴� UI ����
    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu
    {
        get { return uiMainMenu; }
        private set { uiMainMenu = value; }
    }

    // ����â UI ����
    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus
    {
        get { return uiStatus; }
        private set { uiStatus = value; }
    }

    // �κ��丮 UI ����
    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory
    {
        get { return uiInventory; }
        private set { uiInventory = value; }
    }

    private void Awake()
    {
        // �ߺ� ����
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

    // ���� �޴� UI ����
    public void SetMainMenu(UIMainMenu mainMenu)
    {
        UIMainMenu = mainMenu;
    }

    // ����â UI ����
    public void SetStatus(UIStatus status)
    {
        UIStatus = status;
    }

    // �κ��丮 UI ����
    public void SetInventory(UIInventory inventory)
    {
        UIInventory = inventory;
    }
}
