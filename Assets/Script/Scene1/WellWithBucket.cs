using UnityEngine;

public class WellWithBucket : MonoBehaviour
{
    bool isClicked = false;
    private void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;
            Instantiate(Resources.Load<GameObject>("Prefabs/Level_1/board"), transform.position, Quaternion.identity, transform.parent.parent);
        }
    }
}