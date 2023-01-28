using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : interactable
{

    public Item item;
    public override void interact()
    {
        base.interact();

        Pick();
    }

    void Pick()
    {
        inventory.instance.Add(item);
    }
}
