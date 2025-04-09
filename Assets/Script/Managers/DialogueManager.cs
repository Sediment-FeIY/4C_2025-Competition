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
    public string[] dialogues;
    public int L, R;
    IEnumerator Dialogue()
    {
        dialogueText.text = dialogues[L];
        dialogue.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        if (L < R)
        {
            L++;
            Invoke("NextDialogue", 0.2f);
        }else
        {
            StopAllCoroutines();
        }
    }

    public void StartDialogue(int l,int r,Sprite head)
    {
        Speaker.sprite = head;
        L = l; R = r;
        StartCoroutine(Dialogue());
    }

    public void NextDialogue()
    {
        StartCoroutine(Dialogue());
    }

}
