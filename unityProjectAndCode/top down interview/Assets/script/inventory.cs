using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    #region
    public static inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Fail");
            return;
        }
        instance = this;
    }

    #endregion
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;

    public int space = 20;

    public List<Item> items = new List<Item>();

    public bool bHat, bShirt, rHat, rShirt;

    public bool Add(Item item)
    {
       // if (!item.isDeafultItem)
        //{
            if(items.Count >= space)
            {
                return false;
            }

            items.Add(item);

            if (item.name == "BlueHat")
            {
                bHat = true;
            }
            if (item.name == "BlueShirt")
            {
                bShirt = true;
            }
            if (item.name == "RedHat")
            {
                rHat = true;
            }
            if (item.name == "RedShirt")
            {
                rShirt = true;
            }

            if (onItemChangedCallBack !=null)
            onItemChangedCallBack.Invoke();
       // }
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        //if still able to check set return false in item

        if (item.name == "BlueHat")
        {
            bHat = false;
        }
        if (item.name == "BlueShirt")
        {
            bShirt = false;
        }
        if (item.name == "RedHat")
        {
            rHat = false;
        }
        if (item.name == "RedShirt")
        {
            rShirt = false;
        }

        if (onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
    }
}
