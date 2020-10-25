using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class resetConfigData : MonoBehaviour
{
    public Slider sliderBrillo, sliderVolumen;

    public void resetData()
    {
        /*
          
            DeleteAll	Removes all keys and values from the preferences. Use with caution.
            DeleteKey	Removes key and its corresponding value from the preferences.
            GetFloat	Returns the value corresponding to key in the preference file if it exists.
            GetInt	Returns the value corresponding to key in the preference file if it exists.
            GetString	Returns the value corresponding to key in the preference file if it exists.
            HasKey	Returns true if key exists in the preferences.
            Save	Writes all modified preferences to disk.
            SetFloat	Sets the value of the preference identified by key.
            SetInt	Sets the value of the preference identified by key.
            SetString	Sets the value of the preference identified by key.
         */
        PlayerPrefs.DeleteAll();
        Debug.Log("[!] Se reestablecieron las configuraciones");
        sliderBrillo.value = 50;
        sliderVolumen.value = 50;
    }
}
