using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
using System;
using Debug = UnityEngine.Debug;

/*
    Archivo de configuración del valor del slider
*/

public class configValues : MonoBehaviour
{
    public Slider mainSlider;
    public GameObject panelBrillo;
    private Image img;

    void Start()
    {
        img = panelBrillo.GetComponent<Image>();
        int valor = (int)Math.Round((PlayerPrefs.GetFloat("brillo", 0f) - 1) / -0.01);
        mainSlider.value = valor;
    }

    public void setBrillo()
    {
        //0% =      imagen clara
        //100% =    imagen negra
        img.color = new Color(0f, 0f, 0f, (1 - (mainSlider.value * 0.01f)));
        Debug.Log("Brillo en: " + (1 - (mainSlider.value * 0.01f)));
    }
}