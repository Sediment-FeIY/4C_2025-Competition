using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class AudioManager : PersistentSingleton<AudioManager>
{
    void Start()
    {
        BGMAudioSource = GetComponent<AudioSource>();
        SFXVolume = 1f;
        BGMVolume = 1f;
        soundEffects = new Dictionary<string, AudioClip>()
        {
            ["..."] = Resources.Load<AudioClip>("..."),
            ["fork1"] = Resources.Load<AudioClip>("fork1"),
            ["fork2"] = Resources.Load<AudioClip>("fork2")
        };
        BGMs = new Dictionary<string, AudioClip>
        {
            ["..."] = Resources.Load<AudioClip>("...")
        };
        PlayingBGM = "";
    }
    public void PlayBGM(string name)
    {
        if (BGMs == null) return;
        if (!BGMs.Any(bgm => bgm.Key == name))
        {
            Debug.LogError("无BGM!");
        }
        if (BGMAudioSource.clip != null) BGMAudioSource.Stop();
        BGMAudioSource.clip = BGMs[name];
        BGMAudioSource.Play();
        switch (name)
        {
            case "...":
                break;
        }
        PlayingBGM = name;
    }
    public void StopBGM()
    {
        if (BGMAudioSource.clip != null) BGMAudioSource.Stop();
    }
    public void PlaySFX(string name)
    {
        if (!soundEffects.Any(bgm => bgm.Key == name))
        {
            Debug.LogError("无音效!");
        }
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundEffects[name];
        audioSource.volume = SFXVolume;
        audioSource.Play();
        Destroy(audioSource, soundEffects[name].length);
    }
    private float _bgmVolume;
    public float BGMVolume
    {
        get => _bgmVolume;
        set
        {
            _bgmVolume = value;
            BGMAudioSource.volume = value;
        }
    }
    private float _sfxVolume;
    public float SFXVolume
    {
        get => _sfxVolume;
        set => _sfxVolume = value;
    }
    public Dictionary<string, AudioClip> BGMs;
    public Dictionary<string, AudioClip> soundEffects;
    public AudioSource BGMAudioSource;
    public string PlayingBGM;
}
