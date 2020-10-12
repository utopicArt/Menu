using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

/*
    Archivo de configuración del brillo
*/

public class panelBrillo : MonoBehaviour
{
    public Slider slider;
    public GameObject brilloPanel;
    public TextMeshProUGUI valorBrillo;
    private Image img;
    private int sliderValue;

    void Start()
    {
        img = brilloPanel.GetComponent<Image>();
    }

    public void setBrillo()
    {
        img.color = new Color(0f, 0f, 0f, (1 - (slider.value * 0.01f)));
    }
}