using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Paper : Item
{
    public override void OnDragEnd()
    {
        var hits = Physics2D.OverlapPointAll(transform.position);
        foreach (var hit in hits)
        {
            if (hit.gameObject.name == "trigger")
            {
                if (hit.gameObject.transform.parent.parent.Find("installed_board").gameObject.activeSelf)
                {
                    hit.gameObject.transform.parent.Find("text").gameObject.SetActive(true);
                }
                DialogueScene1 temp = GameObject.Find("DialogueManager").GetComponent<DialogueScene1>();
                temp.playDialogue(4);
                return;
            }
        }
        base.OnDragEnd();
    }
}