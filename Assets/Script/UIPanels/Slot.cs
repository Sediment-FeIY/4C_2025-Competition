using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            item.transform.localScale *= 1.1f;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (item != null)
        {
            item.transform.localScale /= 1.1f;
        }
    }
    public InteractableObject item;
}
