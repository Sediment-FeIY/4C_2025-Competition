using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : BasePanel
{
    new void Start()
    {
        base.Start();
        itemList = new List<Item>();
        GetComponent<Canvas>().worldCamera = Camera.main;
    }
    void Update()
    {
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
    }
    public List<Item> itemList;
    public List<Slot> slotList;
}
