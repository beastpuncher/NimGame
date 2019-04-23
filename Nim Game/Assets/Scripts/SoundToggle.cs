using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundToggle : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer = null;
    [SerializeField] bool isOn = true;
    
    public void OnClick()
    {
        isOn = !isOn;
        if (isOn)
        {
            audioMixer.SetFloat("masterVol", -80.0f);
        }
        else
        {
            audioMixer.SetFloat("masterVol", 0.0f);
        }
    }
}
