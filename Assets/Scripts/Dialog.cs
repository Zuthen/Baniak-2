using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public Image avatarDisplay;

    public Speaker[] speakers;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;

    public Speaker[] Speakers { get => speakers; set => speakers = value; }

    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == Speakers[index].sentence)
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        avatarDisplay.sprite = Speakers[index].avatar;
        foreach (char letter in Speakers[index].sentence.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < Speakers.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
}
