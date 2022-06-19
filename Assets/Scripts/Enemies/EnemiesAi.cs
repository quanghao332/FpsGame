using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAi : MonoBehaviour
{
    public string hitTag;
    public bool LookAtPlayer = false;
    public GameObject Enemies;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;
    public int getHurt;
    public AudioSource[] hurtSound;



    void Update()
    {
        RaycastHit Hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if(hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemiesFire());
        }
        if(hitTag != "Player")
        {
            Enemies.GetComponent<Animator>().Play("Idle");
            LookAtPlayer = false;
        }
    }

    IEnumerator EnemiesFire()
    {
        isFiring = true;
        Enemies.GetComponent<Animator>().Play("FirePistol",-1,0);
        Enemies.GetComponent<Animator>().Play("FirePistol");
        LookAtPlayer = true;
        fireSound.Play();
        LookAtPlayer = true;
        GlobalHealth.healthValue -= 5;
        yield return new WaitForSeconds(0.2f);
        getHurt = Random.Range(0, 3);
        hurtSound[getHurt].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
