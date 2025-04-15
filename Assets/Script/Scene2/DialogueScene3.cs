using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScene3 : MonoBehaviour
{
    public DialogueManager manager;
    void Start()
    {
        playDialogue(0);
    }

    public void playDialogue(int ind)
    {
        switch (ind)
        {
            case 0:
                manager.StartDialogue(0, 7);
                break;
            case 1:
                manager.StartDialogue(15, 16);
                break;
            case 2:
                manager.StartDialogue(17, 17);
                break;
            case 3:
                manager.StartDialogue(18, 18);
                break;
            case 4:
                manager.StartDialogue(19, 28);
                break;
        }
    }
}
