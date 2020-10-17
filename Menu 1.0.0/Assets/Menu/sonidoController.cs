using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonidoController : MonoBehaviour
{
    public Image mute, midd, up;
    public Slider slider;
    private int volumen, vol;
    private float active;

    public void volumeLayer()
    {
        vol = (int)Math.Round(slider.value);
        active = (slider.value * 0.02f);
        active = (active <= 0.20f ? 0.2f : active);

        if (vol > 0 && vol < 50)
        {
            midd.color = new Color(1f, 1f, 1f, active);
            mute.color = new Color(1f, 1f, 1f, (1 - (slider.value * 0.015f)));
            up.color = new Color(1f, 1f, 1f, 0.2f);
        }
        else if (vol >= 50)
        {
            active = (1 - (1 - (slider.value / 50f)) * - 1);
            active = (active <= 0.20f ? 0.2f : active);
            up.color = new Color(1f, 1f, 1f, (slider.value * 0.006f));
            midd.color = new Color(1f, 1f, 1f, active);
            mute.color = new Color(1f, 1f, 1f, 0.25f);
        }
        else
        {
            mute.color = new Color(1f, 1f, 1f, 1f);
            midd.color = new Color(1f, 1f, 1f, 0.2f);
            up.color = new Color(1f, 1f, 1f, 0.2f);
        }
    }
}
