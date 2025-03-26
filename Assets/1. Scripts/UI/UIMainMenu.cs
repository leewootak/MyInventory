using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    private bool isStatus, isInventory; // 어떤 창이 열려 있는지 확인

    [Header("Btn")]
    [SerializeField] Button statusBtn;    // 상태창 버튼
    [SerializeField] Button inventoryBtn; // 인벤토리 버튼

    [Header("Reference")]
    [SerializeField] private UIManager UIManager; // UI 매니저 참조

    private void Start()
    {
        // UIManager에 MainMenu 등록
        UIManager.Instance.SetMainMenu(this);

        // 버튼 클릭 이벤트 연결
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    // 메인 메뉴 열기 (다른 창에서 뒤로가기)
    public void OpenMainMenu()
    {
        if (isStatus)
        {
            isStatus = false;
            UIManager.Instance.UIStatus.gameObject.SetActive(false); // 상태창 닫기
            UIManager.Instance.UIMainMenu.gameObject.SetActive(true); // 메인 메뉴 열기
        }
        else if (isInventory)
        {
            isInventory = false;
            UIManager.Instance.UIInventory.gameObject.SetActive(false); // 인벤토리 닫기
            UIManager.Instance.UIMainMenu.gameObject.SetActive(true);   // 메인 메뉴 열기
        }
    }

    // 상태창 열기
    public void OpenStatus()
    {
        isStatus = true;
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false); // 메인 메뉴 닫기
        UIManager.Instance.UIStatus.gameObject.SetActive(true);    // 상태창 열기
    }

    // 인벤토리 열기
    public void OpenInventory()
    {
        isInventory = true;
        UIManager.Instance.UIMainMenu.gameObject.SetActive(false);   // 메인 메뉴 닫기
        UIManager.Instance.UIInventory.gameObject.SetActive(true);   // 인벤토리 열기
    }
}
