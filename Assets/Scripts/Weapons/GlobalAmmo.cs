using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int Ammo;
    public GameObject AmmoDisplay;


    void Update()
    {
        AmmoDisplay.GetComponent<Text>().text = "" + Ammo;
    }
}
