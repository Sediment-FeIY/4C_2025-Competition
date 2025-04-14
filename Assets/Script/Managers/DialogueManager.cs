using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
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
        }else
        {
            StopAllCoroutines();
            dialogue.SetActive(false);
        }
    }

    public void StartDialogue(int l,int r)
    {
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
