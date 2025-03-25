using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public string Title { get; private set; } = "´ººñ";
    public string Name { get; private set; } = "Lee";
    public int Level { get; private set; } = 10;
    public int MaxExp { get; private set; } = 12;
    public int CurExp { get; private set; } = 3;
    public string Gold { get; private set; } = "20,000";
    public int Atk { get; private set; } = 35;
    public int Def { get; private set; } = 40;
    public int Hp { get; private set; } = 10;
    public int Cri { get; private set; } = 25;

    public Image CurExpBar;

    private void Start()
    {
        UIManager.Instance.AlwaysUI.SetCharacterInfo(this);
        UIManager.Instance.UIStatus.SetStatus(this);
        CurExpBar.fillAmount = (float)CurExp / MaxExp;
    }
}
