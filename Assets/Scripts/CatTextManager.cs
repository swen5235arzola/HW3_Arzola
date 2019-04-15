using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Author: Adriana Arzola
/// SWEN 5235 - HW 3 Cats
/// </summary>
public class CatTextManager : MonoBehaviour
{
    public static string description;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        description = string.Empty;
    }

    void Update()
    {
        if (description != null)
        {
            text.text = "Cat Description: " + description;
        }
    }
}
