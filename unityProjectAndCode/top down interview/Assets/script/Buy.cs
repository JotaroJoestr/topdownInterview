using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public Item item;
    public Equipment clothes;
    public inventory inv;
    public charStat stats;

    public bool ableToBuy;

    public void buy()
    {
        checkBuy();

        if(!inv.bHat)
        {
            if(ableToBuy)
            {
                purchase();

                inv.bHat = true;
            }
        }
    }

    public void buy1()
    {
        checkBuy();

        if (!inv.bShirt)
        {
            if (ableToBuy)
            {
                purchase();

                inv.bShirt = true;
            }
        }
    }

    public void buy2()
    {
        checkBuy();

        if (!inv.rHat)
        {
            if (ableToBuy)
            {
                purchase();

                inv.rHat = true;
            }
        }
    }

    public void buy3()
    {
        checkBuy();

        if (!inv.rShirt)
        {
            if (ableToBuy)
            {
                purchase();

                inv.rShirt = true;
            }
        }
    }

    void purchase()
    {
        inventory.instance.Add(clothes);

        stats.coins = stats.coins - clothes.buyPrice;
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
