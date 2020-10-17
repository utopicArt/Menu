using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider sliderVolumen;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void setVolumen()
    {
        audioSource.volume = (sliderVolumen.value * 0.01f);
    }
}
