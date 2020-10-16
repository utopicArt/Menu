using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Debug = UnityEngine.Debug;

public class tmpVolumen1 : MonoBehaviour
{
    private TMP_Text tmp;
    public Slider slider;
    private int sliderValue;

    void Start()
    {
        tmp = GetComponent<TMP_Text>();
    }


    void Update()
    {
        sliderValue = (int)Math.Round(slider.value);
        tmp.text = sliderValue.ToString();
    }
}
