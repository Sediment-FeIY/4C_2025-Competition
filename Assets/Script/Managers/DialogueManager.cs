using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : Singleton<DialogueManager>
{
    public GameObject dialogue;
    public Image Speaker;
    public Text SpeakerName;
    public Text dialogueText;
    public int[] SpeakerOrder;
    public string[] dialogues;
    public string[] SpeakerNames;
    public Sprite[] Heads;
    public int L, R;
    public bool dialogueEnded;
    IEnumerator Dialogue()
    {
        dialogueText.text = dialogues[L];
        dialogue.SetActive(true);
        Speaker.sprite = Heads[SpeakerOrder[L]];
        SpeakerName.text = SpeakerNames[SpeakerOrder[L]];
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        if (L < R)
        {
            L++;
            Invoke("NextDialogue", 0.2f);
        }
        else
        {
            StopAllCoroutines();
            dialogue.SetActive(false);
            dialogueEnded = true;
        }
    }

    public void StartDialogue(int l, int r)
    {
        dialogueEnded = false;
        L = l; R = r;
        StartCoroutine(Dialogue());
    }

    public void NextDialogue()
    {
        StartCoroutine(Dialogue());
    }


    public void Test()
    {
        StartDialogue(0, 14);
    }
}
