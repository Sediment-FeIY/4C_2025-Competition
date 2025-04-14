using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class icebox : MonoBehaviour
{
    public GameObject icebox1;
    public GameObject icebox2;
    public GameObject fatMirror;
    public DialogueScene2 ds;
    public bool flag;
    private void Start()
    {
        flag = false;
    }
    private void OnMouseDown()
    {
        if (!flag)
        {
            flag = true;
            icebox1.SetActive(false);
            icebox2.SetActive(true);
            fatMirror.SetActive(true);
            fatMirror.transform.DOMove(fatMirror.transform.position+new Vector3(0,0.5f,0), 1.0f);
            ds.playDialogue(1);
        }
    }
}
