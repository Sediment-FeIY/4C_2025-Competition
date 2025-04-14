using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    void Start()
    {
        UIManager.Instance.OpenPanel<InventoryPanel>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var colliders = Physics2D.OverlapPointAll(position);
            foreach (var collider in colliders)
            {
                if (collider.gameObject.name == "door")
                {
                    GameManager.Instance.SwitchScene();
                }
            }
        }
    }
    public void SwitchScene()
    {
        if (scene1.activeSelf)
        {
            var panel = UIManager.Instance.GetPanel<InventoryPanel>();
            foreach (var item in panel.itemList)
            {
                item.gameObject.transform.SetParent(scene2.transform, true);
            }
            scene1.SetActive(false);
            scene2.SetActive(true);
            scene1.SetActive(false);
        }
        else
        {
            var panel = UIManager.Instance.GetPanel<InventoryPanel>();
            foreach (var item in panel.itemList)
            {
                item.gameObject.transform.SetParent(scene1.transform, true);
            }
            scene1.SetActive(true);
            scene2.SetActive(false);
        }
    }
    public GameObject scene1;
    public GameObject scene2;
    public Item draggedItem;
}
