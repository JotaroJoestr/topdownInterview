using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{ 
    // for buy and sell panel only
    public Item item;
    public inventory inv;

    public Equipment clothes;

    public charStat stats;

    public GameObject buyUI;
    public GameObject sellUI;

    public GameObject invUI;
    public GameObject shopUI;

    public GameObject shirt;
    public GameObject BlueHatobj, BlueShirtobj;

    public bool ableToBuy;
    public bool blueHat = false;
    public bool blueShirt = false;

    //set another script for real shop and interact only
    //make another script for each item

    /*void Start()
    {
        buyUI.SetActive(true);
        sellUI.SetActive(false);
    }*/

    private void FixedUpdate()
    {
        item = inventory.FindObjectOfType<Equipment>();

        //check if clothes is in inventory
        if (item)
        {
            if (item.name == "BlueHat")
            {
                blueHat = true;
            }
            if (item.name == "BlueShirt")
            {
                blueShirt = true;
            }
        }
    }

    public void buy()
    {
        checkBuy();

        if (!blueHat)
        {
            if (ableToBuy)
            {
                inventory.instance.Add(clothes);

                stats.coins = stats.coins - clothes.buyPrice;

                blueHat = true;

                //BlueHatobj.SetActive(false);
            }
        }
    }

    public void sell()
    {
        if (!item.isDeafultItem)
        {
            item.RemoveFromInventory();
            clothes.RemoveFromInventory();

            stats.coins = stats.coins + item.sellPrice;
        }
    }

    public void close()
    {
        shopUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void checkBuy()
    {
        if (inv.items.Count < inv.space && stats.coins >= clothes.buyPrice)
        {
            ableToBuy = true;
        }
        else if (inv.items.Count >= inv.space || stats.coins < clothes.buyPrice)
        {
            ableToBuy = false;
        }
    }

}
