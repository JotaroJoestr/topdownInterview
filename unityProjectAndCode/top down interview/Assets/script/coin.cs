using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin : MonoBehaviour
{
    public charStat stats;
    public TMP_Text coinDisplay, energyDisplay;
    // Start is called before the first frame update
    void Start()
    {
        coinDisplay.text = ": " + stats.coins.ToString();
        energyDisplay.text = ": " + stats.energy.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.text = ": " + stats.coins.ToString();
        energyDisplay.text = ": " + stats.energy.ToString();
    }
}
