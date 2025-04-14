using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PaperMan : MonoBehaviour
{
    public GameObject[] PaperMen;
    public GameObject[] PaperWomen;
    public DialogueScene2 ds;

    public void Dance()
    {
        StartCoroutine(Dance_());
    }

    IEnumerator  Dance_()
    {
        foreach(var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 0.5f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 0.5f);
        }
        yield return new WaitForSeconds(0.5f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 1f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 1f);
        }
        yield return new WaitForSeconds(1f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 1f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 1f);
        }
        yield return new WaitForSeconds(1f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 1f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 1f);
        }
        yield return new WaitForSeconds(1f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 1f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 1f);
        }
        yield return new WaitForSeconds(1f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, 30, 10), 1f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, -30, -10), 1f);
        }
        yield return new WaitForSeconds(1f);
        foreach (var x in PaperMen)
        {
            x.transform.DORotate(new Vector3(0, 0, 0), 0.5f);
        }
        foreach (var x in PaperWomen)
        {
            x.transform.DORotate(new Vector3(0, 0, 0), 0.5f);
        }
        ds.playDialogue(4);
    }
}
