using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject WpOnGround;
    public GameObject Taking;
    public AudioSource SoundPickUp;


    void OnTriggerEnter(Collider other)
    {
        Taking.SetActive(true);
        WpOnGround.SetActive(false);
        SoundPickUp.Play();
        GetComponent<BoxCollider>().enabled = false;
    }
}
