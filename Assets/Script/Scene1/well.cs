using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class well : MonoBehaviour
{
    public DialogueScene1 ds;
    public bool flag = false;
    private void OnMouseDown()
    {
        if (!flag)
        {
            flag = true;
            ds.playDialogue(3);
        }
    }
}
