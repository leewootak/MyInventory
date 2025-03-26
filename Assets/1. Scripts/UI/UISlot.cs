using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] Image itemIcon;          // 아이템 아이콘 이미지
    [SerializeField] Button itemBtn;          // 장착 버튼
    [SerializeField] GameObject equipMark;    // 장착 여부 표시 오브젝트
    private Item currentItem;                 // 현재 슬롯에 할당된 아이템

    private void Start()
    {
        // 아이템 버튼 클릭 시 OnClick 함수 호출
        itemBtn.onClick.AddListener(OnClick);
    }

    // 슬롯에 아이템 설정
    public void SetItem(Item item)
    {
        currentItem = item;

        if (itemIcon == null)
        {
            return;
        }

        // 아이콘이 있을 경우 표시, 없으면 비활성화
        if (item.Icon != null)
        {
            itemIcon.sprite = item.Icon;
            itemIcon.enabled = true;
        }
        else
        {
            itemIcon.sprite = null;
            itemIcon.enabled = false;
        }

        // 장착 마크 표시 여부 갱신
        ToggleEquipMark(GameManager.Instance.character.IsEquipped(item));
    }

    // 아이템 UI 새로고침
    public void RefreshUI()
    {
        if (currentItem != null)
        {
            ToggleEquipMark(GameManager.Instance.character.IsEquipped(currentItem));
        }
    }

    // 아이템 클릭 시 장착 및 해제
    void OnClick()
    {
        if (currentItem != null)
        {
            GameManager.Instance.character.ToggleEquip(currentItem);

            bool isEquipped = GameManager.Instance.character.IsEquipped(currentItem);
            ToggleEquipMark(isEquipped); // 마크 갱신
        }
    }

    // 장착 마크 토글
    public void ToggleEquipMark(bool active)
    {
        equipMark.SetActive(active);
    }
}
