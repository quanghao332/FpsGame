using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CretsToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(BackToMenu());
    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(3);
    }
}
