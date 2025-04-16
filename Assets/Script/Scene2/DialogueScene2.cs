using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScene2 : MonoBehaviour
{
    public DialogueManager manager;
    private bool lastDialogue = false;
    void Start()
    {
        playDialogue(0);
    }

    void Update()
    {
        if (lastDialogue && DialogueManager.Instance.dialogueEnded)
        {
            SceneLoader.levelSelect = true;
            SceneLoader.Instance.OnEnable();
            lastDialogue = false;
        }
    }

    public void playDialogue(int ind)
    {
        switch (ind)
        {
            case 0:
                manager.StartDialogue(0, 15);
                break;
            case 1:
                manager.StartDialogue(16, 20);
                break;
            case 2:
                manager.StartDialogue(21, 21);
                break;
            case 3:
                manager.StartDialogue(22, 23);
                break;
            case 4:
                lastDialogue = true;
                manager.StartDialogue(24, 29);
                break;
        }
    }

}
