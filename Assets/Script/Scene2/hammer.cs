using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public DialogueScene2 ds;
    public bool isBurned = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tunningFork temp = collision.GetComponent<tunningFork>();
        if (isBurned)
        {
            temp.Shake();
            PaperMan PM = GameObject.Find("PaperMen").GetComponent<PaperMan>();
            PM.Dance();
        }
        else
        {
            ds.playDialogue(3);
        }

    }
}
