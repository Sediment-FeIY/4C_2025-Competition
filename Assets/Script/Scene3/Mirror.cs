using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : Item
{
    public override void OnDragEnd()
    {
        var hits = Physics2D.OverlapPointAll(transform.position);
        foreach (var hit in hits)
        {
            if (hit.gameObject.name == "telescope")
            {
                hit.gameObject.GetComponent<TelescopeItem>().isTelescopeActive = true;
                Destroy(gameObject);
                return;
            }
        }
        base.OnDragEnd();
    }
}
