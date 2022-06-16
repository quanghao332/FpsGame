using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_open : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimObject;
    public bool Action = false;


    void Start()
    {
        Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
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
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(Action == true)
            {
                //Instruction.SetActive(false);
                //Instruction.GetComponent<Text>().text = "Press [F] to open";
                AnimObject.GetComponent<Animator>().Play("OpenDoor");
                Action = false;
            }
            else
            {
                AnimObject.GetComponent<Animator>().Play("CloseDoor");
                //Instruction.GetComponent<Text>().text = "Press [F] to close";
                Action = true;
            }
        }
    }
}
