using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

/*
    Archivo de controlador de niveles y dificultad
*/

public class levelController : MonoBehaviour
{
    private int nivelJuego = 0;
    public GameObject selectorDificultad, message;
    public Button volver, dificultadBtn, jugar, aceptar;
    private int cntr;

    public void setLevel(int nivel)
    {
        nivelJuego = nivel;
    }

    public void goBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void comprobarValores()
    {
        int dificultad = PlayerPrefs.GetInt("dificultad", 0);
        if (nivelJuego > 0 && !dificultad.Equals(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }else if (dificultad.Equals(0))
        {
            selectorDificultad.SetActive(true);
            volver.gameObject.SetActive(false);
            dificultadBtn.gameObject.SetActive(false);
            jugar.gameObject.SetActive(false);
            aceptar.gameObject.SetActive(true);
            cntr++;
        }
        else
        {
            message.SetActive(true);
        }
    }
}
