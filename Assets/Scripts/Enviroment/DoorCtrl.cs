using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCtrl : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimObject;
    public AudioSource DoorSound;
    public bool Action = false;
    public bool isOpen;

    

    void Start()
    {
        Instruction.SetActive(false);
        isOpen = false;
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
        if (Action == true && Input.GetKeyDown(KeyCode.F) && isOpen == false)
        {
            Instruction.SetActive(false);
            AnimObject.GetComponent<Animator>().Play("OpenDoor");
            DoorSound.Play();
            Action = false;
            isOpen = true;
            Instruction.GetComponent<Text>().text = ("Press [F] to close");
        }
        if(Action == true && Input.GetKeyDown(KeyCode.F) && isOpen ==true)
        {
            Instruction.SetActive(false);
            AnimObject.GetComponent<Animator>().Play("CloseDoor");
            DoorSound.Play();
            Action = false;
            isOpen = false;
            Instruction.GetComponent<Text>().text = ("Press [F] to open");
        }
    }
}
