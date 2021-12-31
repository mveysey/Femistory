using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public GameObject LevelUpCanvas;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flag")

            StartCoroutine(display());
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator display()
    {
        LevelUpCanvas.SetActive(true);
        yield return new WaitForSeconds(3);
        LevelUpCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
