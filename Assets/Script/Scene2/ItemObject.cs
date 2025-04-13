using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : InteractableObject
{
    public override void OnDragBegin()
    {
        TestGameManager.Instance.draggedItem = this;
    }
    public override void OnDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public override void OnDragEnd()
    {
        TestGameManager.Instance.draggedItem = null;
    }
}
