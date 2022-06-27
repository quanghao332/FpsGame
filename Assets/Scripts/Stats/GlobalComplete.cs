using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int enemycount;
    public GameObject enemyDisplay;
    public static int nextfloor = 2;
    void Update()
    {
        enemyDisplay.GetComponent<Text>().text = "" + enemycount;

    }
}