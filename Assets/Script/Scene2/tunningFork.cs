using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class tunningFork : MonoBehaviour
{
    public GameObject SunShine;
    public GameObject Rope;
    public GameObject[] Shakes;
    
    public void Fire()
    {
        StartCoroutine(Fire_());
    }

    IEnumerator Fire_()
    {
        SunShine.SetActive(true);
        yield return new WaitForSeconds(2);
        SunShine.SetActive(false);
        Rope.SetActive(false);
    }

    public void Shake()
    {
        StartCoroutine(Shake_());
    }

    IEnumerator Shake_()
    {
        Shakes[0].SetActive(true);
        Shakes[2].SetActive(true);
        Shakes[1].SetActive(false);
        Shakes[3].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Shakes[0].SetActive(false);
        Shakes[2].SetActive(false);
        Shakes[1].SetActive(true);
        Shakes[3].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Shakes[0].SetActive(true);
        Shakes[2].SetActive(true);
        Shakes[1].SetActive(false);
        Shakes[3].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        Shakes[0].SetActive(false);
        Shakes[2].SetActive(false);
        Shakes[1].SetActive(true);
        Shakes[3].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Shakes[0].SetActive(false);
        Shakes[2].SetActive(false);
        Shakes[1].SetActive(false);
        Shakes[3].SetActive(false);
    }
}
