using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeItem : MonoBehaviour
{
    void OnMouseDown()
    {
        if (lockScreen.activeSelf) return;
        if (isTelescopeActive)
        {
            teleTrue.SetActive(true);
        }
        else
        {
            teleFalse.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Cancel");
            teleTrue.SetActive(false);
            teleFalse.SetActive(false);
        }
    }
    public GameObject teleTrue;
    public GameObject teleFalse;
    public GameObject lockScreen;
    public bool isTelescopeActive = false;
}
