using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public GameObject coinIcon;
    public charStat stats;
    public TMP_Text priceTag;
    

    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;

        coinIcon.SetActive(true);
        priceTag.text = "+" + item.sellPrice.ToString();
    }

    public void Clear()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;

        coinIcon.SetActive(false);
    }
    public void sell()
    {
        if (item != null)
        {
            if (!item.isDeafultItem)
            {
                stats.coins = stats.coins + item.sellPrice;

                item.RemoveFromInventory();
            }
        }
    }
    public void UseItem()
    {

        if(item != null)
        {
            Debug.Log("u");

            item.Use();
        }
    }


}
