using UnityEngine;

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