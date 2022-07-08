using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gene : MonoBehaviour
{
    public byte speed { get; private set; }

    System.Random rand = new System.Random();

    public Gene()
    {
        speed = Convert.ToByte(rand.Next(1, 256));
    }

    public Gene(Gene dad, Gene mum)
    {
        Crossover(dad, mum);
    }

    private void Crossover(Gene dad, Gene mum)
    {
        bool bSpeed = rand.NextDouble() > 0.5;

        if (bSpeed)
        {
            speed = mum.speed;
        }
        else
        {
            speed = dad.speed;
        }
    }

}
