using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Debug = UnityEngine.Debug;


/*
    Archivo de obtencion de la configuración guardada
*/

public class getSaved : MonoBehaviour
{

    public GameObject brilloPanel;
    public Slider slider;
    private float brillo;
    private Image nivelBrillo;

    void Start()
    {
        nivelBrillo = brilloPanel.GetComponent<Image>();
        brillo = PlayerPrefs.GetFloat("brillo", 0f);

        brillo = (brillo != 0 ? (int)Math.Round((PlayerPrefs.GetFloat("brillo", 0f) - 1) / -0.01) : 0);
        slider.value = brillo;
        nivelBrillo.color = new Color(0f, 0f, 0f, (1 - (slider.value * 0.01f)));
    }

}
