using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollect : MonoBehaviour
{
    public AudioSource CollectSound;


    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
        CollectSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
