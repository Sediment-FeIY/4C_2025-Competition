using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : Interactable
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        GameManager.Instance.SwitchScene();
    }
}
