using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scientist : MonoBehaviour
{
    public GameObject startUI;

    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;
    public GameObject UI4;

    void Start()
    {
        StartCoroutine(StartDisplay());
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Scientist1")
        {
            UI1.SetActive(true);
            StartCoroutine(Display());
        }

        if (other.gameObject.tag == "Scientist2")
        {
            UI2.SetActive(true);
            StartCoroutine(Display());
        }

        if (other.gameObject.tag == "Scientist3")
        {
            UI3.SetActive(true);
            StartCoroutine(Display());
        }

        if (other.gameObject.tag == "Scientist4")
        {
            UI4.SetActive(true);
            StartCoroutine(Display());
        }

    }

    IEnumerator StartDisplay()
    {
        startUI.SetActive(true);
        yield return new WaitForSeconds(7);
        startUI.SetActive(false);
    }

    IEnumerator Display()
    {
        yield return new WaitForSeconds(10);
        UI1.SetActive(false);
        UI2.SetActive(false);
        UI3.SetActive(false);
        UI4.SetActive(false);
    }
}
