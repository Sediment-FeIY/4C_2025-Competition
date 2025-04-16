using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeItem : MonoBehaviour
{
    void OnMouseDown()
    {
        if (lockScreen.activeSelf) return;
        if (isTelescopeActive)
        {
            teleTrue.SetActive(true);
            DialogueScene3 temp = GameObject.Find("DialogueManager").GetComponent<DialogueScene3>();
            temp.playDialogue(2);
        }
        else
        {
            teleFalse.SetActive(true);
            DialogueScene3 temp = GameObject.Find("DialogueManager").GetComponent<DialogueScene3>();
            temp.playDialogue(1);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Cancel");
            teleTrue.SetActive(false);
            teleFalse.SetActive(false);
        }
    }
    public GameObject teleTrue;
    public GameObject teleFalse;
    public GameObject lockScreen;
    public bool isTelescopeActive = false;
}
