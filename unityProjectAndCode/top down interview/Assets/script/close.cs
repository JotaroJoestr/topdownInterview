using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close : MonoBehaviour
{
    public GameObject shopUI;
    // Start is called before the first frame update
    public void closing()
    {
        shopUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
