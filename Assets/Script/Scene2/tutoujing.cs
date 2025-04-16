using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoujing : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tunningFork temp = collision.GetComponent<tunningFork>();
        temp.Fire();
        audioManager ad = GameObject.Find("audioManager").GetComponent<audioManager>();
        ad.playSFX(3);
        transform.DOMove(new Vector3(4.3f, 0.4f, 0), 0.5f);
        transform.DOScale(new Vector3(0.26f, 0.26f, 1f), 0.5f);
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2.5f);
        GameObject.Find("hammer").GetComponent<hammer>().isBurned = true;
        transform.DOScale(new Vector3(0.13f, 0.13f, 1f), 0.5f);
    }
}
