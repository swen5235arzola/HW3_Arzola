using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Author: Adriana Arzola
/// SWEN 5235 - HW 3 Cats
/// </summary>
public class FightManager : MonoBehaviour
{
    public static bool fight;
    public static int numCats = 0;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        fight = false;
    }

    void Update()
    {
        if (fight)
        {
            text.text = "The Cats are Fighting!";
        }
        else if (!fight && numCats > 6)
        {
            text.text = "The Cats are Happy!";
        }
    }
}
