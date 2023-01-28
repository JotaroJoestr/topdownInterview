using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    //public EquipmentManager em;
    public int sellPrice;

    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDeafultItem = false;

    public virtual void Use()
    {
        Debug.Log(name);
    }

    public void RemoveFromInventory()
    {
        if (this != EquipmentManager.instance.currentEquipment[0] || EquipmentManager.instance.currentEquipment[1]) //if selected doesnt equal to equiped
        {
            inventory.instance.Remove(this);
        }
    }

}
