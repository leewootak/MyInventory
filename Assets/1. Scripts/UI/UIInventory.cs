using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI CurWeight;
    public Button BackBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Start()
    {
        UIManager.Instance.SetInventory(this);
        BackBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }
}
