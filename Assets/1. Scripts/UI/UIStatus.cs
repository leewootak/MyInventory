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
    public Button backBtn;

    [Header("Reference")]
    [SerializeField] UIMainMenu UIMainMenu;

    private void Start()
    {
        UIManager.Instance.SetStatus(this);
        backBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }

    public void SetStatus(Character character)
    {
        curAtk.text = ($"{character.Atk}");
        curDef.text = ($"{character.Def}");
        curHp.text = ($"{character.Hp}");
        curCri.text = ($"{character.Cri}");
    }
}
