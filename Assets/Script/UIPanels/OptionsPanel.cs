using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : BasePanel
{
    new void Start()
    {
        base.Start();
        backButton.onClick.AddListener(UIManager.Instance.TogglePanel<OptionsPanel>);
        BGMVolumeSlider.onValueChanged.AddListener(SetBGMVolume);
        BGMVolumeSlider.value = AudioManager.Instance.BGMVolume;
        SFXVolumeSlider.onValueChanged.AddListener(SetSFXVolume);
        SFXVolumeSlider.value = AudioManager.Instance.SFXVolume;
        fullScreen.onValueChanged.AddListener(SetFullScreen);
        fullScreen.isOn = Screen.fullScreen;
    }
    void Update()
    {
    }
    public void SetBGMVolume(float value)
    {
        AudioManager.Instance.BGMVolume = value;
    }
    public void SetSFXVolume(float value)
    {
        AudioManager.Instance.SFXVolume = value;
    }
    public void SetFullScreen(bool value)
    {
        Screen.fullScreen = value;
    }
    public Button backButton;
    public Slider BGMVolumeSlider;
    public Slider SFXVolumeSlider;
    public Toggle fullScreen;
}
