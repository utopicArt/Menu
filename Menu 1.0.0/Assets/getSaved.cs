using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
    Archivo de obtencion de la configuración guardada
*/

public class getSaved : MonoBehaviour
{

    public GameObject brilloPanel;
    public Slider sliderBrillo, sliderVolumen;
    private float brillo;
    private Image nivelBrillo;
    private float volumen;

    void Start()
    {
        nivelBrillo = brilloPanel.GetComponent<Image>();
        brillo = PlayerPrefs.GetFloat("brillo", 0f);
        volumen = (100f * PlayerPrefs.GetFloat("volumen", 0.5f));

        brillo = (brillo != 0 ? (int)Math.Round((PlayerPrefs.GetFloat("brillo", 0f) - 1) / -0.01) : 0);
        sliderBrillo.value = brillo;
        sliderVolumen.value = volumen;
        nivelBrillo.color = new Color(0f, 0f, 0f, (1 - (sliderBrillo.value * 0.01f)));
    }

}
