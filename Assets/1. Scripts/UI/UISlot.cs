using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] Image itemIcon;
    [SerializeField] Button itemBtn;
    [SerializeField] GameObject equipMark;
    private Item currentItem;

    private void Start()
    {
        itemBtn.onClick.AddListener(OnClick);
    }

    public void SetItem(Item item)
    {
        currentItem = item;
        
        if (itemIcon == null)
        {
            return;
        }

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

        ToggleEquipMark(GameManager.Instance.character.IsEquipped(item));
    }

    public void RefreshUI()
    {
        if (currentItem != null)
        {
            ToggleEquipMark(GameManager.Instance.character.IsEquipped(currentItem));
        }
    }

    void OnClick()
    {
        if (currentItem != null)
        {
            GameManager.Instance.character.ToggleEquip(currentItem);

            bool isEquipped = GameManager.Instance.character.IsEquipped(currentItem);
            ToggleEquipMark(isEquipped);
        }
    }

    public void ToggleEquipMark(bool active)
    {
        equipMark.SetActive(active);
    }
}
