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
        curAtk.text = ($"{character.Atk} (+ {character.GetPlusStat(StatType.Atk)})");
        curDef.text = ($"{character.Def} (+ {character.GetPlusStat(StatType.Def)})");
        curHp.text = ($"{character.Hp} (+ {character.GetPlusStat(StatType.Hp)})");
        curCri.text = ($"{character.Cri} (+ {character.GetPlusStat(StatType.Cri)})");
    }
}
