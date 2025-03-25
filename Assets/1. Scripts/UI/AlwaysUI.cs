using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlwaysUI : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI nickName;
    [SerializeField] TextMeshProUGUI level;
    [SerializeField] Image curExpBar;
    [SerializeField] TextMeshProUGUI curExpText;
    [SerializeField] TextMeshProUGUI maxExpText;
    [SerializeField] TextMeshProUGUI gold;

    private void Start()
    {
        UIManager.Instance.SetAlwaysUI(this);
    }

    public void SetCharacterInfo(Character character)
    {
        title.text = ($"{character.Title}");
        nickName.text = ($"{character.Name}");
        level.text = ($"{character.Level}");
        curExpText.text = ($"{character.CurExp}");
        maxExpText.text = ($"{character.MaxExp}");
        gold.text = ($"{character.Gold}");
    }
}
