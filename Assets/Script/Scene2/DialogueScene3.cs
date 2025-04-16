using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScene3 : MonoBehaviour
{
    public DialogueManager manager;
    public bool tele = false;
    private bool lastDialogue = false;
    void Start()
    {
        playDialogue(0);
    }

    void Update()
    {
        if (lastDialogue && DialogueManager.Instance.dialogueEnded)
        {
            SceneLoader.gameEnding = true;
            SceneLoader.Instance.OnEnable();
            lastDialogue = false;
        }
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
                lastDialogue = true;
                manager.StartDialogue(11, 14);
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
