using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : InteractableObject
{
    public override void OnDragBegin()
    {
        GameManager.Instance.draggedItem = this;
    }
    public override void OnDrag()
    {
        var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }
    public override void OnDragEnd()
    {
        List<RaycastResult> results = RaycastAllUI(Input.mousePosition);
        foreach (var result in results)
        {
            if (result.gameObject.TryGetComponent<Slot>(out var slot))
            {
                slot.item = this;
                var screenPos = RectTransformUtility.WorldToScreenPoint(
                    Camera.main,
                    slot.transform.position);
                slot.item.SetPosition(screenPos);
            }
        }
        GameManager.Instance.draggedItem = null;
    }
    private List<RaycastResult> RaycastAllUI(Vector2 screenPos)
    {
        List<RaycastResult> results = new List<RaycastResult>();
        foreach (var canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.TryGetComponent<GraphicRaycaster>(out var raycaster))
            {
                PointerEventData pointerData = new PointerEventData(EventSystem.current);
                pointerData.position = screenPos;
                raycaster.Raycast(pointerData, results);
            }
        }
        return results;
    }
}
