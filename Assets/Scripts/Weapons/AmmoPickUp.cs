using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public GameObject AmmoClip;
    public AudioSource PickAmmoSound;


    void OnTriggerEnter(Collider other)
    {
        AmmoClip.SetActive(false);
        PickAmmoSound.Play();
        GlobalAmmo.Ammo += 30;
    }
}
