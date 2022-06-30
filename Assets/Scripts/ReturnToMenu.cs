using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(BackToMenu());
    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }
}
