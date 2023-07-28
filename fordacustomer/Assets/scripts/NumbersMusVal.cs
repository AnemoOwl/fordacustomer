using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class NumbersMusVal : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;

    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
        _sliderText.text = v.ToString("0");
        }); 
        _sliderText.text = Convert.ToString(PlayerPrefs.GetFloat("volume"));

    }   

    void Update()
    {
        if( _slider.value != Convert.ToInt32( _sliderText.text ))
        {
            PlayerPrefs.SetFloat("volume", _slider.value);
            PlayerPrefs.Save();
            _slider.value = Convert.ToInt32(_sliderText.text);
        }
    }
}