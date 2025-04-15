using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.UIElements;
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
        bool inSlot = false;
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
                UIManager.Instance.GetPanel<InventoryPanel>().AddItem(this);
                inSlot = true;
                break;
            }
        }
        if (!inSlot)
        {
            var panel = UIManager.Instance.GetPanel<InventoryPanel>();
            var list = panel.itemList;
            if (list.Contains(this))
            {
                list.Remove(this);
            }
            foreach (var slot in panel.slotList)
            {
                if (slot.item == this)
                {
                    slot.item = null;
                }
            }
        }
        GameManager.Instance.draggedItem = null;
    }
    public List<RaycastResult> RaycastAllUI(Vector2 screenPos)
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
