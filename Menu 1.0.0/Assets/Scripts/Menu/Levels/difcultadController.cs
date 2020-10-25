using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difcultadController : MonoBehaviour
{
    public GameObject nivelDificultad;

    public void setDificultad(int dificultad)
    {
        PlayerPrefs.SetInt("dificultad", dificultad);
    }
}
