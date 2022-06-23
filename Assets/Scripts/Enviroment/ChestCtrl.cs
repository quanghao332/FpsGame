using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestCtrl : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimObject;
    public AudioSource ChestSound;
    public bool Action = false;



    void Start()
    {
        Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Instruction.SetActive(false);
        Action = false;
    }

    void Update()
    {
        if (Action == true && Input.GetKeyDown(KeyCode.F) )
        {
            Instruction.SetActive(false);
            AnimObject.GetComponent<Animator>().Play("OpenChest");
            ChestSound.Play();
            Action = false;
            this.GetComponent<ChestCtrl>().enabled = false;
            Instruction.GetComponent<Text>().enabled = false;
            GlobalScore.scoreValue += 500;
        }
    }
}
