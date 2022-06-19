using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject Gun;
    public GameObject muzzleFlash;
    public AudioSource SoundFire;
    public AudioSource EmptyAmmoSound;
    public bool isFiring = false;


    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if(GlobalAmmo.Ammo == 0)
            {
                EmptyAmmoSound.Play();
            }
            else {
                if (isFiring == false)
                {
                    StartCoroutine(FiringGun());
                }
            }
            
        }
    }

    IEnumerator FiringGun()
    {
        isFiring = true;
        GlobalAmmo.Ammo -= 1;
        Gun.GetComponent<Animator>().Play("GunFire");
        muzzleFlash.SetActive(true);
        SoundFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        Gun.GetComponent<Animator>().Play("Idle");
        isFiring = false;
    }
}
