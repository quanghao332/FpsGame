using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLv : MonoBehaviour
{

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        GlobalLife.lifeValue -= 1;
        if(GlobalLife.lifeValue == 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
