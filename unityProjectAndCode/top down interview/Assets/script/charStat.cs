using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charStat : MonoBehaviour
{
    public int coins;
    public int energy;
    public int maxCoins;
    public int maxEnergy;

    void Update()
    {
        if (coins < 0)
        {
            coins = 0;
        }

        if (energy < 0)
        {
            energy = 0;
        }

        if (coins > maxCoins)
        {
            coins = maxCoins;
        }

        if (energy > maxEnergy)
        {
            energy = maxEnergy;
        }
    }
}
