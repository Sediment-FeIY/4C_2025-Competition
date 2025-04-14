using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WoodBoard : Item
{
    public override void OnDragEnd()
    {
        var hits = Physics2D.OverlapPointAll(transform.position);
        foreach (var hit in hits)
        {
            if (hit.gameObject.name == "board_slot")
            {
                GameObject.Find("indoor_scene").transform.Find("installed_board").gameObject.SetActive(true);
                Destroy(gameObject);
                return;
            }
        }
        base.OnDragEnd();
    }
}