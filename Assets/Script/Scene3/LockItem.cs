using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class LockItem : MonoBehaviour
{
    void OnMouseDown()
    {
        OnLockClicked();
    }
    private void OnLockClicked()
    {
        lockPanel.SetActive(true);
    }
    public GameObject lockPanel;
}