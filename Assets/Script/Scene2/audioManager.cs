using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip fork1;
    public AudioClip fork2;
    public AudioClip icebox;
    public AudioClip burn;
    public AudioSource BGMAudioSource;

    private void Start()
    {
        BGMAudioSource = GetComponent<AudioSource>();
    }

    public void playSFX(int ind)
    {
        switch (ind)
        {
            case 0:
                BGMAudioSource.clip = fork1;
                BGMAudioSource.Play();
                Invoke("Test1", 2f);
                break;
            case 1:
                BGMAudioSource.clip = fork2;
                BGMAudioSource.Play();
                Invoke("Test1", 1f);
                break;
            case 2:
                BGMAudioSource.clip = icebox;
                BGMAudioSource.Play();
                Invoke("Test1", 2f);
                break;
            case 3:
                BGMAudioSource.clip = burn;
                BGMAudioSource.Play();
                Invoke("Test1", 2f);
                break;
        }
    }

    private void Test1()
    {
        BGMAudioSource.Stop();
    }
}
