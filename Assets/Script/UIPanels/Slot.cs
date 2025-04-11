using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : Interactable
{
    override public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hello World");
    }
}
