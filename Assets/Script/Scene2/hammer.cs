using DG.Tweening;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour
{
    public DialogueScene2 ds;
    public bool isBurned = false;
    public audioManager ad;

    private void Start()
    {
         ad = GameObject.Find("audioManager").GetComponent<audioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        tunningFork temp = collision.GetComponent<tunningFork>();
        if (isBurned)
        {
            temp.Shake();
            PaperMan PM = GameObject.Find("PaperMen").GetComponent<PaperMan>();
            ad.playSFX(0);
            PM.Dance();
        }
        else
        {
            ad.playSFX(1);
            ds.playDialogue(3);
        }

    }
}
