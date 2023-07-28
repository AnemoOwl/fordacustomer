using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{

    public Slider slider;
    public float oldVolume;

    private void Start()
    {
        oldVolume = slider.value;
        if (!PlayerPrefs.HasKey("volume")) slider.value = 100;
        else slider.value = PlayerPrefs.GetFloat("volume");

    }

    private void Update()
    {
        if( oldVolume != slider.value )
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            PlayerPrefs.Save();
            oldVolume = slider.value;
        }
    }





    // private AudioSource audioSrc;

    // private float musicVolume = 1f;


    // void Start()
    // {
    //     audioSrc = GetComponent<AudioSource>();
    // }
    
    
    // void Update()
    // {
    //     audioSrc.volume = musicVolume;
    // }
    
    // public void SetVolume(float vol)
    // {
    //     musicVolume = vol;
    // }





    // public Slider slider;

    // public AudioClip clip;

    // public AudioSource audio;

    // void Update()
    // {
        // audio.volume = slider.value;
    // }

    // public void PlaySound()
    // {
        // audio.PlayOneShot(clip);
    // }
}
