using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : Interactable
{
    override public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            item.transform.localScale *= 1.1f;
        }
    }
    override public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null)
        {
            item.transform.localScale /= 1.1f;
        }
    }
    override public void OnEndDrag(PointerEventData eventData)
    {
        if (GameManager.Instance.draggedItem != null)
        {
            item = GameManager.Instance.draggedItem;
            GameManager.Instance.draggedItem = null;
        }
    }
    public Item item;
}
