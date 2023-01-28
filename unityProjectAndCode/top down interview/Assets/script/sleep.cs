using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : interactable
{
    public charStat stats;

    public override void interact()
    {
        base.interact();

        stats.energy += 80;
    }
}
