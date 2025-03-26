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
    [SerializeField] UIMainMenu UIMainMenu; // 메인 메뉴 UI 참조

    private void Start()
    {
        // UIManager에 상태창 UI 등록
        UIManager.Instance.SetStatus(this);

        // 뒤로가기 버튼에 메인 메뉴 열기 이벤트 연결
        backBtn.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
    }

    // 캐릭터 능력치 UI에 표시
    public void SetStatus(Character character)
    {
        curAtk.text = ($"{character.Atk} (+ {character.GetPlusStat(StatType.Atk)})");
        curDef.text = ($"{character.Def} (+ {character.GetPlusStat(StatType.Def)})");
        curHp.text = ($"{character.Hp} (+ {character.GetPlusStat(StatType.Hp)})");
        curCri.text = ($"{character.Cri} (+ {character.GetPlusStat(StatType.Cri)})");
    }
}
