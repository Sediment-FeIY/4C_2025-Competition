using UnityEngine;
using UnityEngine.UIElements;

public class InteractableObject : MonoBehaviour
{
    public bool isPointerOver;
    public bool IsPointerOver
    {
        get => isPointerOver;
        set
        {
            isPointerOver = value;
            if (isPointerOver == true)
            {
                OnPointerEnter();
            }
            else
            {
                OnPointerExit();
            }
        }
    }
    public void SetPosition(Vector3 screenPos)
    {
        var position = Camera.main.ScreenToWorldPoint(screenPos);
        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }
    virtual public void OnPointerEnter()
    {

    }
    virtual public void OnPointerExit()
    {

    }
    virtual public void OnPointerClick()
    {

    }
    virtual public void OnDragBegin()
    {

    }
    virtual public void OnDrag()
    {

    }
    virtual public void OnDragEnd()
    {

    }
    virtual public void OnPointerUp()
    {

    }
}