using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeColor : MonoBehaviour {
    private static string blue = "blue";
    private static string green = "green";
    private static string pink = "pink";
    private static string purple = "purple";
    private static string red = "red";
    private static string yellow = "yellow";

    private List<string> possibilities = new List<string> { blue, green, pink, purple, red, yellow };

    private static int randomIndex;
    public static string randomizedColor;
    public static int correctColorIndex;

    void Start () {
        randomIndex = Random.Range(0, possibilities.Count);
        randomizedColor = possibilities[randomIndex];
        Debug.Log(randomizedColor);

        correctColorIndex = possibilities.IndexOf(randomizedColor);
        Debug.Log(correctColorIndex);
    }


}
