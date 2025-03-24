using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI curAtk;
    public TextMeshProUGUI curDef;
    public TextMeshProUGUI curHp;
    public TextMeshProUGUI curCri;
    public Button BackBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Start()
    {
        UIManager.Instance.SetStatus(this);
        BackBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }
}
