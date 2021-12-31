using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    public GameObject Background;
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;

    public GameObject Q1Trigger;
    public GameObject Q2Trigger;
    public GameObject Q3Trigger;
    public GameObject Q4Trigger;
    public GameObject Q5Trigger;

    public GameObject Stars0;
    public GameObject Stars1;
    public GameObject Stars2;
    public GameObject Stars3;
    public GameObject Stars4;
    public GameObject Stars5;

    public GameObject Incorrect;
    public GameObject Correct;

    public int stars;

    void Start()
    {
        stars = 5; 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Question1")
        {
            Q1Trigger.SetActive(false);
            Time.timeScale = 0f;
            Background.SetActive(true);
            Q1.SetActive(true);
        }
        if (other.gameObject.tag == "Question2")
        {
            Q2Trigger.SetActive(false);
            Time.timeScale = 0f;
            Background.SetActive(true);
            Q2.SetActive(true);
        }
        if (other.gameObject.tag == "Question3")
        {
            Q3Trigger.SetActive(false);
            Time.timeScale = 0f;
            Background.SetActive(true);
            Q3.SetActive(true);
        }
        if (other.gameObject.tag == "Question4")
        {
            Q4Trigger.SetActive(false);
            Time.timeScale = 0f;
            Background.SetActive(true);
            Q4.SetActive(true);
        }
        if (other.gameObject.tag == "Question5")
        {
            Q5Trigger.SetActive(false);
            Time.timeScale = 0f;
            Background.SetActive(true);
            Q5.SetActive(true);
        }


        if (other.gameObject.tag == "Flag") { 
            StartCoroutine(Display());
        }
    }

    public void ClickCorrectAnswer()
    {
        StartCoroutine(CorrectDisplay());
        Time.timeScale = 1f;
        Background.SetActive(false);
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
    }

    public void ClickIncorrectAnswer()
    {
        StartCoroutine(IncorrectDisplay());
        Time.timeScale = 1f;
        stars--;
    }

    IEnumerator CorrectDisplay()
    {
        Correct.SetActive(true);
        yield return new WaitForSeconds(1f);
        Correct.SetActive(false);
    }

    IEnumerator IncorrectDisplay()
    {
        Incorrect.SetActive(true);
        yield return new WaitForSeconds(1f);
        Incorrect.SetActive(false);
    }

    IEnumerator Display()
    {
        if (stars == 1)
        {
            Stars1.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars1.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (stars == 2)
        {
            Stars2.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars2.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (stars == 3)
        {
            Stars3.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars3.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (stars == 4)
        {
            Stars4.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars4.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (stars == 5)
        {
            Stars5.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars5.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else 
        {
            Stars0.SetActive(true);
            yield return new WaitForSeconds(3);
            Stars0.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
