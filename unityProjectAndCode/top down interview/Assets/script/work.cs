using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class work : interactable
{
    public Item item;

    public charStat stats;

    int rng;
    public override void interact()
    {
        base.interact();

        if (stats.energy >= 10)
        {
            working();

            drop();
        }
    }

    void working()
    {
        stats.coins += 10;
        stats.energy -= 10;
    }

    void drop()
    {
        rng = Random.Range(0, 10);

        if(rng == 5)
        {
            inventory.instance.Add(item);
        }
    }
}
