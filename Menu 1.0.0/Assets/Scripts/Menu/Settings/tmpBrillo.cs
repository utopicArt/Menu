using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Debug = UnityEngine.Debug;

/*
    Archivo de configuración del valor de brillo
*/

public class tmpBrillo : MonoBehaviour
{
    private TMP_Text tmp;
    public Slider mainSlider;
    private int sliderValue;

    void Start()
    {
        tmp = GetComponent<TMP_Text>();
    }

    
    void Update()
    {
        sliderValue = (int)Math.Round(mainSlider.value);
        tmp.text = sliderValue.ToString();
    }
}
