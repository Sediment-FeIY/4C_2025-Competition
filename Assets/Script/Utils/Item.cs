using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : Interactable
{
    public override void OnBeginDrag(PointerEventData eventData)
    {
        GameManager.Instance.draggedItem = this;
    }
    public override void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameManager.Instance.draggedItem = null;
    }
}