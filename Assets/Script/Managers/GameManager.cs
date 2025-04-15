using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    void Start()
    {
        var panel = UIManager.Instance.OpenPanel<InventoryPanel>();
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            panel.AddItem(GameObject.Find("paper").GetComponent<Item>());
        }
        if (SceneManager.GetActiveScene().name == "Scene3")
        {
            panel.AddItem(GameObject.Find("fat mirror").GetComponent<Item>());
        }
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
