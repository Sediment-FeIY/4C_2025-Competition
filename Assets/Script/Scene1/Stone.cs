using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Stone : Item
{
    public DialogueScene1 ds;
    public bool flag = false;
    private void OnMouseDown()
    {
        if (!flag)
        {
            flag = true;
            ds.playDialogue(2);
        }
    }
    public override void OnDragEnd()
    {
        var hits = Physics2D.OverlapPointAll(transform.position);
        foreach (var hit in hits)
        {
            if (hit.gameObject.name == "lever_original")
            {
                hit.gameObject.transform.parent.Find("lever_active").gameObject.SetActive(true);
                hit.gameObject.SetActive(false);
                GameObject.Find("well").transform.Find("well_original").gameObject.SetActive(false);
                GameObject.Find("well").transform.Find("well_with_bucket").gameObject.SetActive(true);
                Destroy(gameObject);
                return;
            }
        }
        base.OnDragEnd();
    }
}