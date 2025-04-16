using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScene1 : MonoBehaviour
{
    public DialogueManager manager;
    public SceneLoader sceneLoader;
    private bool lastDialogue = false;
    void Start()
    {
        lastDialogue = false;
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
                manager.StartDialogue(0, 14);
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
                lastDialogue = true;
                manager.StartDialogue(19, 28);
                break;
        }
    }
}
