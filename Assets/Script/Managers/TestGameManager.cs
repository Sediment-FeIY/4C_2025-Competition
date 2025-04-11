using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    void Start()
    {
        UIManager.Instance.OpenPanel<OptionsPanel>();
        UIManager.Instance.OpenPanel<InventoryPanel>();
    }
    void Update()
    {

    }
}
