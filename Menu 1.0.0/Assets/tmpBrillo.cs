using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

/*
    Archivo de configuración del valor de brillo
*/

public class tmpBrillo : MonoBehaviour
{
    private TMP_Text tmp;
    private int score;
    public Slider mainSlider;
    private int sliderValue;

    void Start()
    {
        tmp = GetComponent<TMP_Text>();
        score = 0;
    }

    
    void Update()
    {
        sliderValue = (int)mainSlider.value;
        tmp.text = sliderValue.ToString();
        score++;
    }
}
