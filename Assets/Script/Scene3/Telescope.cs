using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Telescope : MonoBehaviour
{
    private Button telescope;
    private GameObject telescopeButton;
    private GameObject teleTrue;
    private GameObject teleFalse;

    private bool isTelescopeActive = false;
    void Start()
    {
        // telescopeButton = GameObject.Find("Telescope");
        // telescope = telescopeButton.GetComponent<Button>();
        // teleTrue = GameObject.Find("TelescopeTrue");
        // teleFalse = GameObject.Find("TelescopeFalse");
        // teleTrue.SetActive(false);
        // teleFalse.SetActive(false);
        // telescope.onClick.AddListener(OnTelescopeClick);
    }

    //目前打算是设置一个bool变量，放好道具之前为false，放好道具之后为true，根据true和false来判断是否显示放大图
    private void OnTelescopeClick()
    {
        if (isTelescopeActive)
        {
            teleTrue.SetActive(true);
            
        }
        else
        {
            teleFalse.SetActive(true);
            
        }
    }

    private void Cancel()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Cancel");
            teleTrue.SetActive(false);
            teleFalse.SetActive(false);
        }
    }

    private void ScopeActive()
    {
        isTelescopeActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Cancel();
    }

}
