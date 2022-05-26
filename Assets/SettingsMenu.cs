using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;
    public void SetMusicVolume (float volume)
    {
        musicMixer.SetFloat("musicvolume", volume);
        PlayerPrefs.SetFloat("musicvolume", volume);
    }
    public void SetSFXVolume (float volume)
    {
        sfxMixer.SetFloat("sfxvolume", volume);
    }
}
