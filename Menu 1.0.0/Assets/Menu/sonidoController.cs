using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class sonidoController : MonoBehaviour
{
    public Image mute, midd, up;
    public Slider slider;
    private int volumen, vol;
    private float active;

    void Start()
    {
        up.color = new Color(255f, 255f, 255f, 0.2f);
    }

    public void volumeLayer()
    {
        vol = (int)Math.Round(slider.value);
        active = (slider.value * 0.02f);
        active = (active <= 0.20f ? 0.2f : active);
        if (vol > 0 && vol <= 50)
        {
            midd.color = new Color(255f, 255f, 255f, active);
            mute.color = new Color(255f, 255f, 255f, (1 - (slider.value * 0.01f)));
            up.color = new Color(255f, 255f, 255f, 0.2f);
        }
        else if (vol > 50)
        {
            up.color = new Color(255f, 255f, 255f, (slider.value * 0.01f));
            midd.color = new Color(255f, 255f, 255f, (1 - (1 - (slider.value / 50f)) * - 1));
        }
        else
        {
            mute.color = new Color(255f, 255f, 255f, 1f);
            midd.color = new Color(255f, 255f, 255f, 0.2f);
            up.color = new Color(255f, 255f, 255f, 0.2f);
        }
    }
}
