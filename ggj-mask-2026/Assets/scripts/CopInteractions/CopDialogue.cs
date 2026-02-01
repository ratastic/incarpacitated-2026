using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CopDialogue : MonoBehaviour
{
    [Header("Questions Settings")]
    public GameObject Question1;
    public GameObject Question2;
    public GameObject Question3;
    public GameObject Question4;
    public GameObject allQuestions;
    public int answerIndex; //Index (#)

    [Header("Text Settings")]
    public TextMeshProUGUI DialogetextComponent;
    public string[] lines;
    public float textSpeed; //typing Speed
    public int questionIndex; //Index (#)

    [Header("Timer")]
    public float timer;
    public float startTime = 10f;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip roosterSound;
    public AudioClip pigSound;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("You get arrested"); //ADD ENDING
        }
    }

    void Start()
    {
        //Reset Game
        timer = startTime;
        questionIndex = 0;
        answerIndex = 1;
        HideQuetions();

        //Reset and Start Cop Dialoge
        DialogetextComponent.text = string.Empty;
        StartDialogue();
 
    }

    void StartDialogue()
    {
        StartCoroutine(TypeDialoge());
    }

    IEnumerator TypeDialoge()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(pigSound);
        foreach (char c in lines[questionIndex].ToCharArray())
        {
            DialogetextComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        PushQuestions(); //Next set of questions activates

    }

    void NextLine() //Move to the next line of dialoge and type
    {
        {
            questionIndex += 1;
            DialogetextComponent.text = string.Empty;
            StartCoroutine(TypeDialoge());
        }
    }

    void PushQuestions()
    {
        ToggleQuestions();

        if (answerIndex == 1)
        {
            Question1.SetActive(true);
        }
        else if (answerIndex == 2)
        {
            Question1.SetActive(false);
            Question2.SetActive(true);
        }
        else if (answerIndex == 3)
        {
            Question2.SetActive(false);
            Question3.SetActive(true);
        }
        else if (answerIndex == 4)
        {
            Question3.SetActive(false);
            Question4.SetActive(true);
        }
        else if (answerIndex >= 5)
        {
            Question4.SetActive(false);
            HideQuetions();
            Debug.Log("Transition to the next scene"); //ADD SCENE TRANSITION
        }
    }

    void HideQuetions()
    {
        allQuestions.SetActive(false);
    }

    void ToggleQuestions()
    {
        allQuestions.SetActive(true);
    }

    public void GoodAnswer()
    {
        audioSource.PlayOneShot(roosterSound);
        answerIndex += 1;
        HideQuetions();
        NextLine();
        timer = startTime;
    }
    public void BadAnswer()
    {
        audioSource.PlayOneShot(roosterSound);
        HideQuetions();
        Debug.Log("You get arrested"); //ADD ENDING
    }


}
