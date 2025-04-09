using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testDialogue : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public Sprite a;
    public void Test1()
    {
        dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        dialogueManager.StartDialogue(1, 4, a);
    }
}
