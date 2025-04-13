using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : Singleton<TestGameManager>
{
    void Start()
    {
        UIManager.Instance.OpenPanel<OptionsPanel>();
        UIManager.Instance.OpenPanel<InventoryPanel>();
    }
    void Update()
    {

    }
    public ItemObject draggedItem;
}
