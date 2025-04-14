using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : InteractableObject
{
    public bool hammer;
    public bool isBurned;
    public DialogueScene2 ds;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tunningFork temp = collision.GetComponent<tunningFork>();
        if (!hammer)
        {
            temp.Fire();
            transform.DOMove(new Vector3(4.3f, 0.4f, 0), 0.5f);
            transform.DOScale(new Vector3(0.26f, 0.26f, 1f), 0.5f);
            StartCoroutine(Death());
        }
        else
        {
            if (isBurned)
            {
                temp.Shake();
                PaperMan PM = GameObject.Find("PaperMen").GetComponent<PaperMan>();
                PM.Dance();
            }
            else
            {
                ds.playDialogue(3);
            }

        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2.5f);
        GameObject.Find("hammer").GetComponent<Item>().isBurned = true;
        transform.DOScale(new Vector3(0.13f, 0.13f, 1f), 0.5f);
    }
}
