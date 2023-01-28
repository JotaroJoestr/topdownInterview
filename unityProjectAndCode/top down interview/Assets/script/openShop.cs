using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openShop : interactable
{
    public GameObject shopUI;
    public GameObject invUI;

    public override void interact()
    {
        base.interact();

        shopUI.SetActive(true);
        invUI.SetActive(false);
        Time.timeScale = 0f;
    }
}
