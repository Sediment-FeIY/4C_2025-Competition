using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScene3 : MonoBehaviour
{
    public DialogueManager manager;
    public bool tele = false;
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
                manager.StartDialogue(8, 9);
                break;
            case 2:
                manager.StartDialogue(10, 10);
                break;
            case 3:
                manager.StartDialogue(11, 16);
                break;

        }
    }

    public void Telescope()
    {
        if (!tele)
        {
            tele = true;
            playDialogue(1);
        }
       
    }
}
