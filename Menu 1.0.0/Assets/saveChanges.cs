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
    public Slider slider;

    public void comparar()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("brillo", 0f);
        if (!brilloGuardado.Equals(1 - (slider.value * 0.01f)))
        {
            Debug.Log("El valor cambió: " + brilloGuardado + " - Valor actual: " + (1 - (slider.value * 0.01f)));
            guardar("brillo");
        }
    }

    public void guardar(string componente)
    {
        switch (componente)
        {
            case "brillo":
                PlayerPrefs.SetFloat("brillo", (1 - (slider.value * 0.01f)));
                break;
            case "sonido":
                PlayerPrefs.SetInt("sonido", (PlayerPrefs.GetInt("sonido", 0) == 0?1:0));
                break;
        }
    }
}
