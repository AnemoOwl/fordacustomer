using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio_;
    

    void Start()
    {
        if (!PlayerPrefs.HasKey("volume")) GetComponent<AudioSource>().volume = 1;
        else audio_.volume = PlayerPrefs.GetFloat("volume");
    }

    void Update()
    {
       audio_.volume = PlayerPrefs.GetFloat("volume")/100; 
    }
}
