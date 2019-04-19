using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] AudioSource m_music = null;
    public string m_id = null;
    [SerializeField] Image m_image = null;
   public void Mute()
    {
        if (m_music.mute == false) m_music.mute = true;
        else m_music.mute = false;
    }
    public void Play()
    {
       // m_music.mute = false;
    }
}
