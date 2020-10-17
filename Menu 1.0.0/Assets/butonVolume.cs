using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butonVolume : MonoBehaviour
{
    public Slider slider;
    public Image mute, middle, up;

    public void setCustomVolume(int volumeLevel)
    {
        slider.value = volumeLevel;
        switch (volumeLevel)
        {
            case 0:
                mute.color = new Color(1f, 1f, 1f, 1f);
                middle.color = new Color(1f, 1f, 1f, 0.2f);
                up.color = new Color(1f, 1f, 1f, 0.2f);
                break;
            case 1:
                mute.color = new Color(1f, 1f, 1f, 0.2f);
                middle.color = new Color(1f, 1f, 1f, 1f);
                up.color = new Color(1f, 1f, 1f, 0.2f);
                break;
            case 2:
                mute.color = new Color(1f, 1f, 1f, 0.2f);
                middle.color = new Color(1f, 1f, 1f, 0.2f);
                up.color = new Color(1f, 1f, 1f, 1f);
                break;
        }
    }

}
