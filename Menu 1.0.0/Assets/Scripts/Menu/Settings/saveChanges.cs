using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

/*
    Archivo de guardado de configuraciones
*/

public class saveChanges : MonoBehaviour
{
    public Slider sliderBrillo, sliderVolumen;
    public GameObject message, panelPrincipal, panelConfig;

    public void Nuevoscambios()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("brillo", 0.5f);
        float volumenGuardado = (100f * PlayerPrefs.GetFloat("volumen", 0.5f));
        bool existenCambios = false;

        brilloGuardado = (brilloGuardado != 0 ? (int)Math.Round((PlayerPrefs.GetFloat("brillo", 0.5f) - 1) / -0.01) : 0);

        if (!sliderBrillo.value.Equals(brilloGuardado))
        {
            existenCambios = true;
        }
        if (!sliderVolumen.value.Equals(volumenGuardado))
        {
            existenCambios = true;
        }

        message.SetActive((existenCambios?true:false));
        panelPrincipal.SetActive((existenCambios?false:true));
        panelConfig.SetActive((existenCambios?true:false));
    }

    public void comparar()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("brillo", 0.5f);
        int volumenGuardado = (int)Math.Round(PlayerPrefs.GetFloat("volumen", 0.5f));

        if (!brilloGuardado.Equals(1 - (sliderBrillo.value * 0.01f)))
        {
            guardar("brillo");
        }
        if (!volumenGuardado.Equals(1 - (sliderVolumen.value * 0.01f)))
        {
            guardar("volumen");
        }
    }

    public void guardar(string componente)
    {
        switch (componente)
        {
            case "brillo":
                PlayerPrefs.SetFloat("brillo", (1 - (sliderBrillo.value * 0.01f)));
                break;
            case "volumen":
                PlayerPrefs.SetFloat("volumen", (sliderVolumen.value * 0.01f));
                /*
                 * Nivel máximo icono volumeUp.
                 * Que empiece nivel 50 - icono nivel medio.
                 * Nivel mínimo icono mute.
                 * > 50 icono volumeUp cada vez más nítido conforme se mueve el slider.
                 * < 50 icono mute cada vez más nítido conforme se mueve el slider.
                 */
                break;
        }
    }
}
