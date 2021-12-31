using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("50s");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("60s");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("70s");
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("80s");
    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene("90s");
    }
}
