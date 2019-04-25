using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    [SerializeField] GameObject help_screen = null;

    public void HelpClick()
    {
        if(help_screen.activeSelf)
        {
            help_screen.SetActive(false);
        }
        else
        {
            help_screen.SetActive(true);
        }
    }
    
}
