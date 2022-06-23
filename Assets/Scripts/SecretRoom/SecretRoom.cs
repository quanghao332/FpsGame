using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretRoom : MonoBehaviour
{
    public GameObject movableWall;

    void OnTriggerEnter(Collider other)
    {
        movableWall.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
