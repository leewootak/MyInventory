using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 싱글톤 인스턴스
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    // 항상 활성화되는 UI 참조
    [SerializeField] private AlwaysUI alwaysUI;
    public AlwaysUI AlwaysUI 
    { 
        get { return alwaysUI; } 
        private set { alwaysUI = value; }
    }

    // 메인 메뉴 UI 참조
    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu
    {
        get { return uiMainMenu; }
        private set { uiMainMenu = value; }
    }

    // 상태창 UI 참조
    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus
    {
        get { return uiStatus; }
        private set { uiStatus = value; }
    }

    // 인벤토리 UI 참조
    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory
    {
        get { return uiInventory; }
        private set { uiInventory = value; }
    }

    private void Awake()
    {
        // 중복 방지
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

    // 항상 활성화되는 UI 설정
    public void SetAlwaysUI(AlwaysUI always)
    {
        AlwaysUI = always;
    }

    // 메인 메뉴 UI 설정
    public void SetMainMenu(UIMainMenu mainMenu)
    {
        UIMainMenu = mainMenu;
    }

    // 상태창 UI 설정
    public void SetStatus(UIStatus status)
    {
        UIStatus = status;
    }

    // 인벤토리 UI 설정
    public void SetInventory(UIInventory inventory)
    {
        UIInventory = inventory;
    }
}
