using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    void Awake()
    {
        isPointerOverObjects = new List<InteractableObject>();
        isDraggingObjects = new List<InteractableObject>();
    }
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D[] hitColliders = Physics2D.OverlapPointAll(mousePosition);
        List<InteractableObject> currentIsPointerOverObjects = new List<InteractableObject>();
        foreach (var collider in hitColliders)
        {
            if (collider.TryGetComponent<InteractableObject>(out var interactable))
            {
                currentIsPointerOverObjects.Add(interactable);
                if (!interactable.IsPointerOver)
                {
                    interactable.IsPointerOver = true;
                    isPointerOverObjects.Add(interactable);
                }
            }
        }
        List<InteractableObject> pointerExitObjects = isPointerOverObjects.Where(obj => !currentIsPointerOverObjects.Contains(obj)).ToList();
        foreach (var obj in pointerExitObjects)
        {
            obj.IsPointerOver = false;
            isPointerOverObjects.Remove(obj);
        }
        if (Input.GetMouseButtonDown(0))
        {
            foreach (var obj in isPointerOverObjects)
            {
                obj.OnPointerClick();
                obj.OnDragBegin();
                isDraggingObjects.Add(obj);
            }
        }
        if (Input.GetMouseButton(0))
        {
            foreach (var obj in isDraggingObjects)
            {
                obj.OnDrag();
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDraggingObjects.Clear();
            foreach (var obj in isPointerOverObjects)
            {
                obj.OnPointerUp();
                obj.OnDragEnd();
            }
        }
    }
    private List<InteractableObject> isPointerOverObjects;
    private List<InteractableObject> isDraggingObjects;
}